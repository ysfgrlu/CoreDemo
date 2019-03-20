using KarateOrganization.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Entities
{
    public class Club:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
    }
}
