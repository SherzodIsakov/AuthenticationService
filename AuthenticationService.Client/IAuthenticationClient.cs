using AuthenticationBase.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Threading.Tasks;

namespace AuthenticationService.Client
{
    public interface IAuthenticationClient
    {
        //[Post("/Auth/signup")]
        //Task<ObjectResult> SignUp([Body] SignUpModel signUpModel);

        [Post("/Auth/login")]
        Task<ObjectResult> Login([Body] LoginModel loginModel);
    }
}
