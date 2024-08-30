namespace SocialApp.Models
{
    public class PostDoc
    {
        public string postId { get; set; }
        public string postTitle { get; set; }

        public string postBody { get; set; }

        public List<string> postImgURL { get; set; } // an array of URLs of the images in the same post

        public List<string> likes { get; set; } // an array of uid

        public List<string> CommentDocList { get; set; } // an array of comDocId

        public string createdBy { get; set; }

        public DateTime createdAt { get; set; }

    }
}
