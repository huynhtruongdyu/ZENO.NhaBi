using NhaBi.Domain.Common;

namespace NhaBi.Domain.Entities
{
    internal class Product : BaseEntity, ISoftDeleteEntity
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}