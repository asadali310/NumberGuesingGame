
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;


namespace Webapiapplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private static List<Player> Players = new List<Player>();

        private static readonly int[] Id = new[]
        {
            12,13,14,15,16
        };
        private static string[] name = new[]
        {

            "asad", "ali","jawad","umair"
        };
        [HttpGet]
        

        [HttpGet]

        public IEnumerable<Player> Get()
        {
            return Enumerable.Range(1, 4).Select(index => new Player
            {
                Name = name[Random.Shared.Next(name.Length)],
                PlayerId = Id[Random.Shared.Next(Id.Length)] 
                
            })
               .ToArray();
        }

        [HttpGet("{Get Id}")]

        public Player Get(int Id)
        {
            var Player = Players.Find(x => x.PlayerId == Id );
            if(Player == null)
            {
                throw new Exception(" Player is not found");
            }

            return Player;
        }
        [HttpPost]
        public Player Post()
        {
            var Ply = new Player
            {
                Name = name[Random.Shared.Next(name.Length)],
                PlayerId = Id[Random.Shared.Next(Id.Length)]
            };
            Players.Add(Ply);
            return Ply;
        }
    }
}
