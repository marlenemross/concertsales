using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repositories
{
    public class ConcertsRepository
    {
        private List<Concert> concerts = new List<Concert> ();
        private MusicianRepository musicianRepository = new MusicianRepository();

        public void CreateConcert(String name, DateTime concertDate, int ticketsAvailable, int ticketsSold)
        {
            Concert concert = new Concert()
            {
                Name = name,
                ConcertDate = concertDate,
                TicketsAvailable = ticketsAvailable,
                TicketsSold = ticketsSold,
                musicians = new List<Musician>()
            };
            concerts.Add(concert);

        }

        public List<Concert> GetAllConcerts()
        {
            return concerts;
        }

        public Concert GetConcert(String name)
        {
            int i = 0;
            while ((i < concerts.Count) || concerts[i].Name != name )
            { i++; }
            return concerts[i];
        }

        public Concert BuyTickets(String name, int tickets)
        {
            int i = 0;
            while ((i < concerts.Count) || concerts[i].Name != name)
            { i++; }
            concerts[i].TicketsAvailable = concerts[i].TicketsAvailable - tickets;
            concerts[i].TicketsSold = concerts[i].TicketsSold + tickets;
            return concerts[i];
        }


        public Musician GetConcertHasMusician(Concert concert,String musicianName)
        {
            int i = 0;
            while ((i < concert.musicians.Count) || concert.musicians[i].Name != musicianName)
            { i++; }
            return concert.musicians[i];
        }

        public void UpdateConcertWithMusician( String concertName, String musicianName)
        {
            Concert concertToUpdate = GetConcert(concertName);

            Musician musicianToUpdate = GetConcertHasMusician(concertToUpdate, musicianName);
            if (musicianToUpdate == null)
            {
                musicianToUpdate = musicianRepository.GetMusician(musicianName);
                concertToUpdate.musicians.Add(musicianToUpdate);
            }
            else
            {
                concertToUpdate.musicians.Remove(musicianToUpdate);
            }

        }

    }
}
