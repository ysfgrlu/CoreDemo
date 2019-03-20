using KarateOrganization.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Entities
{
    public class Tournament : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public float Tolerance { get; set; }

    }
}
