using KarateOrganization.Core;
using KarateOrganization.Entities;

namespace KarateOrganization.DataAccess
{
    public class EfOrganizationDal : EfEntityRepositoryBase<Organization, KarateOrganizationContext>, IOrganizationDal
    {

    }
}
