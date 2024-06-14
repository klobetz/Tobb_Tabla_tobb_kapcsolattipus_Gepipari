using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class Post
    {
        public int PostId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required]
        [MaxLength(2000)]
        public string? Content { get; set; }

        //többhöz az egyhez viszony (külső kulcs)
        public int UserId { get; set; }
        public virtual User? User { get; set; }

    }
}
