using KarateOrganization.Dtos;
using KarateOrganization.Entities;
using System.Collections.Generic;

namespace KarateOrganization.Business
{
    public interface IClubService
    {
        List<Club> GetAll();
        Club GetClubById(int clubId);
        List<ComboSourceDto> GetClubs();
        void Add(Club club);
        void Update(Club club);
        void Delete(int clubId);
        bool SaveAll();
    }
}
