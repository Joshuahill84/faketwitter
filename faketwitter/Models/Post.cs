using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace faketwitter.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Text { get; set; }
        public DateTime PostedDate { get; set; }
        public virtual User user { get; set; }
        

    }
}