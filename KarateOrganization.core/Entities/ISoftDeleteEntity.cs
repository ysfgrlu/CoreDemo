using System;
namespace KarateOrganization.Core
{
    public interface ISoftDeleteEntity:IEntity
    { 
        bool IsActive { get; set; }
    }
}
