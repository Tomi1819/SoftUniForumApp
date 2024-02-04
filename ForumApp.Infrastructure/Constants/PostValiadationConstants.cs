namespace ForumApp.Infrastructure.Constants
{
    public class PostValiadationConstants
    {
        public const int TitleMinLenght = 10;
        public const int TitleMaxLenght = 50;

        public const int ContentMinLenght = 30;
        public const int ContentMaxLenght = 1500;

        public const string RequiredErrorMessage = "The {0} is required";
        public const string StringLenghtMessage = "The {field} must be between {2} and {1} characters.";
    }
}
