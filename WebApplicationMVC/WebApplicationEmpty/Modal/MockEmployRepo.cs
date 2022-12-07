using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEmpty.Modal
{
    public class MockEmployRepo:IEmployRepository
    {
        public  List<Employee> _employee = new List<Employee>();
       public MockEmployRepo() {
            _employee.Add (new Employee() { id = 1, name = "shreyas", age = 22 });
            _employee.Add( new Employee() { id = 2, name = "himagirish", age = 21 });
        }

        public IEnumerable<Employee> GetAllEmployees() {
            return _employee;
        }



        Employee IEmployRepository.GetEmployee(int id) {
            return _employee.FirstOrDefault(e => e.id == id);
            //return _employee.Find(e => e.id == id);
        }

        }
}
