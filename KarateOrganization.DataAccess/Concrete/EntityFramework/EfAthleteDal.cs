using KarateOrganization.Core;
using KarateOrganization.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KarateOrganization.DataAccess
{
    public class EfAthleteDal:EfBaseEntityRepositoryBase<Athlete,KarateOrganizationContext>, IAthleteDal
    {
        public override Athlete Get(Expression<Func<Athlete, bool>> filter)
        {
           return GetList().Include(a => a.Club).SingleOrDefault(filter);
        }
    }
}
