using BethanysPieShopHRM.Data.Abstractions;
using BethanysPieShopHRM.Shared.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShopHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(employeeRepository.GetAllEmployees());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int employeeId)
        {
            return Ok(employeeRepository.GetEmployeeById(employeeId));
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee newEmployee)
        {
            if (newEmployee == null)
                return BadRequest();

            if (newEmployee.FirstName == string.Empty || newEmployee.LastName == string.Empty)
            {
                ModelState.AddModelError("FirstName/Lastname", "The first name or last name shouldn't be empty.");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdemployee = employeeRepository.AddEmployee(newEmployee);
            return Created("employee", createdemployee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        public IActionResult UpdateEmployee([FromBody] Employee updatedEmployee)
        {
            if (updatedEmployee == null)
                return BadRequest();

            if (updatedEmployee.FirstName == string.Empty || updatedEmployee.LastName == string.Empty)
                ModelState.AddModelError("FirstName/Lastname", "The first name or last name shouldn't be empty.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeToUpdate = employeeRepository.GetEmployeeById(updatedEmployee.EmployeeId);

            if (employeeToUpdate == null)
                return NotFound();

            employeeRepository.UpdateEmployee(employeeToUpdate);

            return NoContent(); //Success
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            var employeeToDelete = employeeRepository.GetEmployeeById(id);
            if (employeeToDelete == null)
                return NotFound();

            employeeRepository.DeleteEmployee(id);

            return NoContent();//Success
        }
    }
}
