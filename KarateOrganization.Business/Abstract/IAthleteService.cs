using KarateOrganization.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Business
{
    public interface IAthleteService
    {
        List<Athlete> GetAll();
        Athlete GetAthleteById(int athleteId);
        void Add(Athlete athlete);
        void Update(Athlete athlete);
        void Delete(int athleteId);
        bool SaveAll();
    }
}
