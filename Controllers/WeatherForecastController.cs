using Microsoft.AspNetCore.Mvc;
using WebApiTest1.Models;

namespace WebApiTest1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetWeatherForecast")]
        public string[] Get(int id)
        {
            string[] names = { "A", "B", "C" };
            return names;
        }

        [HttpGet(Name = "GetEmpName")]
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { EmpId=1, Name="Anu", Address="Address1" });
            employees.Add(new Employee() { EmpId=2, Name="Balu", Address ="Address2" });
            employees.Add(new Employee() { EmpId =3, Name="Charan", Address="Address2"});
            return employees;
        }
    }
}
