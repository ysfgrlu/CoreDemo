using KarateOrganization.Core;
using KarateOrganization.Entities;

namespace KarateOrganization.DataAccess
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, KarateOrganizationContext>, ICategoryDal
    {

    }
}
