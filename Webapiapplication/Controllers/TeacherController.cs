using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Webapiapplication.Controllers
{
  
        [ApiController]
        [Route("[controller]")]
        public class TeacherController : ControllerBase
        {
            private static readonly string[] Names = new[]
            {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

            private readonly ILogger<TeacherController> _logger;
       
        public TeacherController(ILogger<TeacherController> logger)
            {
                _logger = logger;
            }

            [HttpGet]
            public IEnumerable<Teacher> Get()
            {
                return Enumerable.Range(1, 3).Select(index => new Teacher
                {   
                    Department = Random.Shared.Next(10, 50),
                    Name = Names[Random.Shared.Next(Names.Length)]
                })
                .ToArray();
            }
        }



    }
