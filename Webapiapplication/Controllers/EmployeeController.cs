using Microsoft.AspNetCore.Mvc;

namespace Webapiapplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>();
        private static readonly string[] Names = new[]
        {
        "Asad", "Aamir","Ayan","Rahman","Jawad","Asalm"
        };
        private static readonly int[] Ages = new[]
        { 1, 2, 3, 4, 4, 5, 5, 6, 7, 7, 8
        };
        private static readonly int[] Ids= new[]
        { 12, 22, 33, 44, 45, 15, 35, 16, 17, 37,28
        };

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {

            
            return Enumerable.Range(1, 5).Select( index => 
            {
                
                int v = Random.Shared.Next(16, 30);
                return new Employee
                {
                    EmployeeNmae = Names[Random.Shared.Next(Names.Length)],
                    EmployeeId = Ids[Random.Shared.Next(Ids.Length)],
                    EmployeeAge = v
                };
            })
            .ToArray();
        }
        [HttpPost]
        public Employee Post()
        {
            var std = new Employee
            {
                EmployeeNmae = Names[Random.Shared.Next(Names.Length)],
                EmployeeId = Ids[Random.Shared.Next(Ids.Length)],
                EmployeeAge = Random.Shared.Next(16, 59)
            };
            employees.Add(std);
           return  std;
        }
       
  
    }

}

