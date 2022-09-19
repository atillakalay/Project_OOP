namespace Project_OOP.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
