using KarateOrganization.Core;
using KarateOrganization.Entities;

namespace KarateOrganization.DataAccess
{
    public class EfTournamentDal : EfEntityRepositoryBase<Tournament, KarateOrganizationContext>, ITournamentDal
    {

    }
}
