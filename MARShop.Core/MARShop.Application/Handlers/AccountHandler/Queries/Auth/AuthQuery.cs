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
using BCrypt.Net;

namespace MARShop.Application.Handlers.AccountHandler.Queries.Auth
{
    public class AuthQuery : IRequest<Respond<string>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class AuthQueryHandler : IRequestHandler<AuthQuery, Respond<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public AuthQueryHandler(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<Respond<string>> Handle(AuthQuery request, CancellationToken cancellationToken)
        {
            var account = await _unitOfWork.Accounts.DFistOrDefaultAsync(a => a.Email == request.Email);

            if (account == null) throw new AppException("Email not found");
            if (!BCrypt.Net.BCrypt.Verify(request.Password, account.Password)) throw new AppException("Wrong password");

            var token = CreateToken(account);

            return Respond<string>.Success(token);
        }
        private string CreateToken(Account user)
        {
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Role, user.Role),
                new Claim("UserName", user.UserName),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
