using KarateOrganization.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Entities
{
    public class Coach : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsMain { get; set; }
        public string Email { get; set; }

        public int ClubId { get; set; }

        public virtual Club Club { get; set; }
    }
}
