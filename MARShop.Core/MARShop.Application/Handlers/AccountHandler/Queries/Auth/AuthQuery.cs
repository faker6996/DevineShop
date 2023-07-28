using MARShop.Application.Common;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;
using MARShop.Core.Entities;
using Microsoft.Extensions.Configuration;
using MARShop.Application.Middleware;
using Microsoft.Extensions.Logging;

namespace MARShop.Application.Handlers.AccountHandler.Queries.Auth
{
    public class AuthQuery : IRequest<Respond<AuthRespond>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class AuthRespond
    {
        public string AccountId { get; set; }
        public string AccountEmail { get; set; }
        public string AccountName { get; set; }
        public string Token { get; set; }
    }
    public class AuthQueryHandler : IRequestHandler<AuthQuery, Respond<AuthRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthQueryHandler> _logger;

        public AuthQueryHandler(IUnitOfWork unitOfWork, IConfiguration configuration,ILogger<AuthQueryHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<Respond<AuthRespond>> Handle(AuthQuery request, CancellationToken cancellationToken)
        {
            _logger.LogTrace(@"Method auth called.");
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Email == request.Email);

            if (account == null) throw new AppException("Email không có trong hệ thống");
            if (!BCrypt.Net.BCrypt.Verify(request.Password, account.Password)) throw new AppException("Sai mật khẩu");

            var token = CreateToken(account);
            var authRespond = new AuthRespond()
            {
                AccountId = account.Id,
                AccountEmail = account.Email,
                AccountName = account.Name,
                Token = token
            };

            return Respond<AuthRespond>.Success(authRespond);
        }
        private string CreateToken(Account user)
        {
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Role, user.Role),
                new Claim("UserName", user.UserName),
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: credentials);

            var jwt = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

            return jwt;
        }

    }
}
