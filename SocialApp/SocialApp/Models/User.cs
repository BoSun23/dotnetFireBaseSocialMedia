using System.Collections.Generic;

namespace SocialApp.Models
{
    public class User
    {
        public string uid { get; set; }
        public string profileid { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }

        public string profilePicURL { get; set; }

        public string bio { get; set; }

        public DateTime createdAt { get; set; }

        public List<string> Followers { get; set; } // An array of uid from other user
        public List<string> Following { get; set; } // An array of uid from other user
        public List<string> Posts { get; set; } // An array of postId




    }
}
