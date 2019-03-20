using System;
namespace KarateOrganization.Core
{
    public class SoftDeleteEntity:ISoftDeleteEntity
    {
        public SoftDeleteEntity()
        {
        }

        public bool IsActive { get; set; }
    }
}
