using KarateOrganization.Core;
using KarateOrganization.DataAccess;
using KarateOrganization.Entities;

namespace KarateOrganization.DataAccess
{
    public class EfClubDal : EfBaseEntityRepositoryBase<Club, KarateOrganizationContext>, IClubDal
    {

    }
}
