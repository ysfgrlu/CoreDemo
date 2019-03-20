using KarateOrganization.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Entities
{
    public class TournamentAthlete : BaseEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TournementId { get; set; }
        public int AthleteId { get; set; }
    }
}
