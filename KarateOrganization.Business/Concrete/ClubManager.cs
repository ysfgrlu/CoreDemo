using System.Collections.Generic;
using System.Linq;
using KarateOrganization.DataAccess;
using KarateOrganization.Dtos;
using KarateOrganization.Entities;

namespace KarateOrganization.Business
{
    public class ClubManager : IClubService
    {
        private IClubDal _clubDal;
        public ClubManager(IClubDal clubDal)
        {
            _clubDal = clubDal;
        }
        public void Add(Club club)
        {
            _clubDal.Add(club);
        }

        public void Delete(int clubId)
        {
            _clubDal.Delete(new Club { Id=clubId});
        }

        public List<Club> GetAll()
        {
            return _clubDal.GetList().ToList();
        }

        public Club GetClubById(int clubId)
        {
            return _clubDal.Get(c => c.Id == clubId);
        }

        public List<ComboSourceDto> GetClubs()
        {
            return _clubDal.GetList().Select(c=>new ComboSourceDto{Id=c.Id, Name=c.Name}).ToList();
        }

        public bool SaveAll()
        {
            return _clubDal.SaveAll();
        }

        public void Update(Club club)
        {
            _clubDal.Update(club);
        }
    }
}
