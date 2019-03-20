using KarateOrganization.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Entities
{
    public class Organization:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}
