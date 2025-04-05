using EmployeeManagementSystem.Autentication.Models;
using EmployeeManagementSystem.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
       private readonly   IJWTManagerRepository _AuthRespository;

      public  AuthenticationController(IJWTManagerRepository repo)
        {
            _AuthRespository = repo;
        }
        [HttpPost]
        public IActionResult Login([FromBody]User user)
        {
            var token = _AuthRespository.Autenticate(user);
            if(token==null || token==string.Empty)
            {
                return Unauthorized();
            }
            return Ok(token);
        }

    }
}
