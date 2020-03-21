using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repositories
{
    public class MusicianRepository
    {
        private List<Musician> musicians = new List<Musician>();
        public void CreateMusician(String name, String typeOfMusician, Decimal fee)
        {
            Musician musician = new Musician()
            {
                Name = name,
                TypeOfMusician = typeOfMusician,
                Fee = fee
            };
        
        }

        public List<Musician> GetAllMusicians()
        {
            return musicians;
        }
        public Musician GetMusician(String name)
        {
            int i = 0;
            while ((i < musicians.Count) || musicians[i].Name != name)
            { i++; }
            return musicians[i];
        }
    }
}
