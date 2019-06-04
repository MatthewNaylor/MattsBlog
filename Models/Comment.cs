using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MattsBlog.Models
{
    public class Comment
    {
        //primary key
        public int Id { get; set; }

        //foreign key
        public int BlogPostId { get; set; }
        public string UserId { get; set; }

        public string CommentBody { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public string UpdateReason { get; set; }

        //Navigational properties
        public virtual BlogPost BlogPost { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}