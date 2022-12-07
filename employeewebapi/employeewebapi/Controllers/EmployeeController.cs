using employeewebapi.Model;
using employeewebapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace employeewebapi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [ApiController]
    [Route("[Controller]")]
   
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        [ActivatorUtilitiesConstructor]

        public EmployeeController(IEmployeeRepository employeeRepository) {
            EmployeeRepository = employeeRepository;
        }
        public readonly IEmployeeRepository EmployeeRepository;
        [HttpGet]
        [Route("Test/Get")]
        public int Index() {
            return 20;
        }
        [HttpGet]
        [Route ("Employee/Get")]
       // [DisableCors]
        public IEnumerable<Employee> GetEmployees() {
            return EmployeeRepository.GetAllEmployee();
        }
        [HttpGet]
        [Route("Employee/Get/{id}")]
        public Employee GetEmployeeById(int id) {
            return EmployeeRepository.GetEmployee(id);
        }
        [HttpPost]
        [Route("Employee/Post")]
        public Employee AddEmployee(Employee employee) {
            var newemployee = EmployeeRepository.Add(employee);
            return (newemployee);
        }
        [HttpDelete]
        [Route ("Employee/Delete/{id}")]
        public Employee DeleteEmployee( int id) {
             var delemployee= EmployeeRepository.Delete(id);
            return (delemployee);
        }
    }
}
