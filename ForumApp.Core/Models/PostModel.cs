namespace ForumApp.Core.Models
{
    using static ForumApp.Infrastructure.Constants.PostValiadationConstants;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Post data transfer model
    /// </summary>
    public class PostModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(TitleMaxLenght,
            MinimumLength = TitleMinLenght,
            ErrorMessage = StringLenghtMessage)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(ContentMaxLenght,
            MinimumLength = TitleMinLenght,
            ErrorMessage = StringLenghtMessage)]
        public string Content { get; set; } = string.Empty;
    }
}
