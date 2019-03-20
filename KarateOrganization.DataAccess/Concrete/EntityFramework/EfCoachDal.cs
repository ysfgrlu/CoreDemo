using KarateOrganization.Core;
using KarateOrganization.Entities;

namespace KarateOrganization.DataAccess
{
    public class EfCoachDal : EfEntityRepositoryBase<Coach, KarateOrganizationContext>, ICoachDal
    {

    }
}
