using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace hwBlog.Models
{
    public class BlogPost
    {

        //new blog post and this sets up data structure to hold all comments related to that blog post. HashSet is a type of collection, similar but more efficient than list ( because it doesn't allow duplicates). You can't loop through by index, only via enumerator (using for each)
        public BlogPost()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        [AllowHtml]
        public string Title { get; set; }
        public string Slug { get; set; }
        [AllowHtml]
        public string Body { get; set; }
        public string MediaURL { get; set; }
        public bool Published { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
