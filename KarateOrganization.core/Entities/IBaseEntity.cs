using System;
namespace KarateOrganization.Core
{
    public interface IBaseEntity:IEntity
    {
        DateTime CreatedDate { get; set; }
        int CreatedUserId { get; set; }
        DateTime? ModifiedDate { get; set; }
        int? ModifiedUserId { get; set; }
        bool IsActive { get; set; }
    }
}
