using KarateOrganization.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.Entities
{
    public class TournamentReferee : BaseEntity
    {
        public int Id { get; set; }
        public int TournementId { get; set; }
        public int RefereeId { get; set; }
    }
}
