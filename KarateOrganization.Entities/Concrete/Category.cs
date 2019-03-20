using KarateOrganization.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Entities
{
    public class Category:BaseEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int BirthYear { get; set; }
        public bool Gender { get; set; }
        public float GroupWeight { get; set; }

        public int TournementId { get; set; }

        public virtual Tournament Tournament { get; set; }
    }
}
