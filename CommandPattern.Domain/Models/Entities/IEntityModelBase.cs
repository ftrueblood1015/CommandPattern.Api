namespace CommandPattern.Domain.Models.Entities
{
    public interface IEntityModelBase
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
