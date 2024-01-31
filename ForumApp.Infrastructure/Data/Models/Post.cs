namespace ForumApp.Infrastructure.Data.Models
{
    using static ForumApp.Infrastructure.Constants.PostValiadationConstants;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    [Comment("Posts table")]
    public class Post
    {
        [Key]
        [Comment("Post identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Post title")]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Comment("Post Content")]
        [MaxLength(ContentMaxLenght)]
        public string Content { get; set; } = string.Empty;
    }
}
