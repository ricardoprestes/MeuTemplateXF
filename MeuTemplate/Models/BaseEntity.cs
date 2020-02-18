namespace MeuTemplate.Models
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public bool Removed { get; set; }
    }
}
