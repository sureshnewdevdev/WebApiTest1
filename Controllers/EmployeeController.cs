using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTest1.Models;

namespace WebApiTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<Employee> employees = new List<Employee>();
        public EmployeeController()
        {
            //employees.Add(new Employee() { EmpId = 1, Name = "Anu", Address = "Address1" });
            //employees.Add(new Employee() { EmpId = 2, Name = "Balu", Address = "Address2" });
            //employees.Add(new Employee() { EmpId = 3, Name = "Charan", Address = "Address2" });
           
        }

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        [HttpGet("GetEmployeeByID")]
        public List<Employee> GetEmployees(int id)
        {
            return employees.Where(emp=>emp.EmpId == id).ToList<Employee>();
        }

        [HttpPost]
        public string AddEmployee(Employee emp)
        {
            employees.Add( emp);
            return emp.Name;
        }

        [HttpPut]
        public string UpdateEmployee(int empId,Employee emp)
        {
            var index = employees.FindIndex(emp=>emp.EmpId == empId);
            employees[index] = emp;
            return empId.ToString();
        }
    }
}
