using System;

namespace KarateOrganization.Core
{
    public class BaseEntity:IBaseEntity, ISoftDeleteEntity
    {
        public BaseEntity()
        {
        }

        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUserId { get; set; }
        public bool IsActive { get; set; }
    }
}
