using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Webapiapplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> Students = new List<Student>();   
        private static readonly string[] Names = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" , "Aamir"
        };

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger; 
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return Students;
        }
       [HttpPost]
        public Student Post()
        {
            var std = new Student
            {
                Name = Names[Random.Shared.Next(Names.Length)],
                RollNo = Random.Shared.Next(2000,10000)
            };
            Students.Add(std);
            return std;
        }
        
        [HttpPut]
        public Student Put([FromBody]Student input)
        {
            var student = Students.Find(x => x.Name == input.Name);
            if (student == null)
            {
                throw new Exception("Student not found!");
            }
            student.RollNo = input.RollNo;
            student.Name = input.Name;
            return student;


        }
        [HttpGet("{rollNo}")]
        
        public Student Get(int rollNo)
        {
            var student = Students.Find(x => x.RollNo == rollNo);
            if (student == null)
            {
                throw new Exception("Student not found!");
            }
            return student;


        }
       
        [HttpDelete("{name}")]
        public Student Delete(string name)
        {
            var Student = Students.Find(x => x.Name == name);
            if (Student == null)
            {
                throw new Exception("Student not found!");
            }
            Students.Remove(Student);
            return Student;
        }
      

    }
}

