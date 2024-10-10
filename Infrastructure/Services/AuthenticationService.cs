using Application.Interfaces;
using Application.Model.Request;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AuthenticationService: IAuthenticationService
    {
        //private readonly IUserRepository _userRepository;
        //public AuthenticationService(IUserRepository userRepostory)
        //{
        //    _userRepository = userRepostory;
        //}
        //private User? ValidationUser(CredentialRequest authenticationRequest)
        //{
        //    if (string.IsNullOrEmpty(authenticationRequest.email) || string.IsNullOrEmpty(authenticationRequest.password))
        //    {
        //        return null;
        //    }
            
        //    var user = _userRepository.GetUserByEmail(authenticationRequest.email);

        //    if (user == null) return null;

        //    if ((user.UserRole == UserRole.Admin || user.UserRole == UserRole.Patient || user.UserRole == UserRole.Doctor) && user.Password== authenticationRequest.password)
        //    {
        //        return user;
        //    }
        //    return null;

        //}
        //public UserAuthenticateModel? AuthenticateCredentials(CredentialRequest credentialRequest)
        //{
        ////    var user = ValidationUser(credentialRequest);
        ////    if (user == null)
        ////    {
        ////        throw new UnauthorizedAccessException("Fallo en la autenticación del usuario");
        ////    }
        ////    var securityPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_options.SecretForKey)); //Traemos la SecretKey del Json. agregar antes: using Microsoft.IdentityModel.Tokens;
        ////    var credentials = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

        //    return null;
        //}
    }
}

