using Microsoft.AspNetCore.Mvc.Rendering;

namespace omcabujas.ViewModels
{
    public class CreatePostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}
