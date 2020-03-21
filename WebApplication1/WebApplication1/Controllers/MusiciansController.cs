using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[Controller]")]



    public class MusiciansController
    { 
    public MusicianRepository musicianRepository = new MusicianRepository();


    [HttpGet("musicians")]
        public IEnumerable<Musician> GetMusicians()
        {
            return musicianRepository.GetAllMusicians();
        }

        [HttpGet("musician")]
        public Musician GetMusician(String firstName, String lastName)
        {
            String name = firstName + ' ' + lastName;
            return musicianRepository.GetMusician(name);

        }

        [HttpPost("create-musician")]
        public String CreateMusician([FromBody] Musician musician)
        {
            musicianRepository.CreateMusician(musician.Name, musician.TypeOfMusician, musician.Fee);
            return musician.Name;
        }
    }
}
