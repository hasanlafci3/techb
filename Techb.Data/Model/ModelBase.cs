namespace Techb.Data.Model
{
    public abstract class ModelBase
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
