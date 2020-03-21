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
    public class ConcertSalesController
    {
        private ConcertsRepository concertsRepository = new ConcertsRepository();
       
        [HttpGet("concerts")]
        public IEnumerable<Concert> GetConcerts()
        {
            return concertsRepository.GetAllConcerts();

        }

        [HttpGet("concert")]
        public Concert GetConcert([FromBody] String name)
        {
            return concertsRepository.GetConcert(name);

        }

        [HttpPut("buy-tickets")]
        public Concert BuyTickets([FromBody] String name, int tickets)
        {
            return concertsRepository.BuyTickets(name, tickets);

        }

        [HttpPost("create-concert")]
        public String CreateConcert([FromBody] Concert concert)
        {
            concertsRepository.CreateConcert(concert.Name, concert.ConcertDate, concert.TicketsAvailable, concert.TicketsSold);
            return concert.Name;
        }

        [HttpPost("update-concert-with-musician")]
        public String UpdateConcertWithMusician([FromBody] String concertName, String musicianName )
        {
            concertsRepository.UpdateConcertWithMusician(concertName, musicianName);
            return "Concert updated";
        }
        
    }
}
