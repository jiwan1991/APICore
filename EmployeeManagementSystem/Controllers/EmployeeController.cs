using System.Text.Json;
using EmployeeManagementSystem.Entity.Models;
using EmployeeManagementSystem.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmpCollection<Employee> _employee;
        public EmployeeController(IEmpCollection<Employee> employee)
        {
            _employee = employee;
        }
        [Authorize]
        [HttpGet]
        public IActionResult GetAllEmployee()
        {

            return Ok(_employee.GetAll());
        }
        [HttpGet]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(_employee.GetbyId(id));
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody]Employee entity)
        {

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _employee.ADD(entity);
            return  Ok();
        }

    }
}
