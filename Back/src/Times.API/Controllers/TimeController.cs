using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Times.API.Models;

namespace Times.API.Controllers
{
    [ApiController]
    [Route("[controller]/classificacao_geral")]
    public class CampeonatoController : ControllerBase
    {
        public IEnumerable<Time> _time = new Time[] 
        {
            new Time() {
            TimeId = 1,
            Jogada = "Test 1",
            Resultado= "1 x 2"
            },
            new Time() {
            TimeId = 2,
            Jogada = "Test 3",
            Resultado= "4 x 3"
            }
        };
        public CampeonatoController()
        {             
        }

        [HttpGet]
        public IEnumerable<Time> Get()
        {
            return _time;
        }

        [HttpGet("{id}")]
        public IEnumerable<Time> GetById(int id)
        {
            return _time.Where(time => time.TimeId == id);
        }

        [HttpPost]
        public bool Post(Time time) {

            Console.WriteLine(time.TimeId);
            Console.WriteLine(time.Jogada);
            Console.WriteLine(time.Resultado);

            return true;
        }
    }
}
