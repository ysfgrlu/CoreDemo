using KarateOrganization.DataAccess;
using KarateOrganization.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarateOrganization.Business
{
    public class AthleteManager : IAthleteService
    {
        private IAthleteDal _athleteDal;
        public AthleteManager(IAthleteDal athleteDal)
        {
            _athleteDal = athleteDal;
        }
        public List<Athlete> GetAll()
        {
            return _athleteDal.GetList().Include(a=>a.Club).ToList();
        }
        public Athlete GetAthleteById(int athleteId)
        {
            return _athleteDal.Get(a => a.Id == athleteId);
        }
        public void Add(Athlete athlete)
        {
            if (athlete.BirthYear > DateTime.Now.Year) {
                throw new Exception();
            }
            _athleteDal.Add(athlete);
        }

        public void Delete(int athleteId)
        {
            _athleteDal.Delete(new Athlete { Id = athleteId });
        }
        public void Update(Athlete athlete)
        {
            _athleteDal.Update(athlete);
        }

        public bool SaveAll()
        {
            return _athleteDal.SaveAll();
        }
    }
}
