namespace CommandPattern.Domain.Models.Entities
{
    public class EntityModelBase : IEntityModelBase
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
