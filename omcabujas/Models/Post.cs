namespace omcabujas.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; } = new HashSet<PostCategory>();
        public string ApplicationId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
