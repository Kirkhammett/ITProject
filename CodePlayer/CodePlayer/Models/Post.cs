using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodePlayer.Models
{
    public class Post
    {
        public string PostID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}