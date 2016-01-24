namespace CodePlayer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Post
    {
        public string PostID { get; set; }

        public string UserID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
    }
}
