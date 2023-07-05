using MARShop.Application.Common;
using MARShop.Application.Middleware;
using MARShop.Core.Entities;
using MARShop.Infastructure.UnitOfWork;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.Extensions.Configuration;
using MARShop.Core.Enum;

namespace MARShop.Application.Handlers.AccountHandler.Queries.Auth
{
    public class AdminAuthQuery : IRequest<Respond<AdminAuthRespond>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class AdminAuthRespond
    {
        public string AccountId { get; set; }
        public string AccountEmail { get; set; }
        public string AccountName { get; set; }
        public string Token { get; set; }
    }
    public class AdminAuthQueryHandler : IRequestHandler<AdminAuthQuery, Respond<AdminAuthRespond>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public AdminAuthQueryHandler(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<Respond<AdminAuthRespond>> Handle(AdminAuthQuery request, CancellationToken cancellationToken)
        {
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Email == request.Email && a.Role == nameof(Role.Admin));

            if (account == null) throw new AppException("Email Admin không có trong hệ thống");
            if (!BCrypt.Net.BCrypt.Verify(request.Password, account.Password)) throw new AppException("Sai mật khẩu");

            var token = CreateToken(account);
            var authRespond = new AdminAuthRespond()
            {
                AccountId = account.Id,
                AccountEmail = account.Email,
                AccountName = account.Name,
                Token = token
            };

            return Respond<AdminAuthRespond>.Success(authRespond);
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
