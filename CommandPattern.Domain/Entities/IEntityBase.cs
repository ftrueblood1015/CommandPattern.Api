namespace CommandPattern.Domain.Entities
{
    public interface IEntityBase
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
