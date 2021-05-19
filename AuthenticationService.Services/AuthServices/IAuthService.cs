using AuthenticationBase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AuthenticationService.Services.AuthServices
{
    public interface IAuthService
    {
        Task<ObjectResult> SignUp(SignUpModel signUpModel);
        Task<ObjectResult> Login(LoginModel loginModel);
    }
}
