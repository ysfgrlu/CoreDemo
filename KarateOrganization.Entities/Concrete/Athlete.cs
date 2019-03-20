using KarateOrganization.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Entities
{
    public class Athlete:BaseEntity
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public int BirthYear { get; set; }
        public int Belt { get; set; }
        public string ImageUrl { get; set; }

        public int ClubId { get; set; }

        public virtual Club Club { get; set; }
    }
}