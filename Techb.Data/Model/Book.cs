namespace Techb.Data.Model
{
    public class Book : ModelBase
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
    }
}
