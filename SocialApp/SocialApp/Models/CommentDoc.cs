namespace SocialApp.Models
{
    public class CommentDoc
    {
        public string comId {  get; set; }

        public string createdBy { get; set; } // uid

        public DateTime createdAt { get; set; }

        public string  relatedPostId { get; set; }
    }
}
