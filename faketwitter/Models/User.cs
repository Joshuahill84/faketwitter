using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace faketwitter.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<Post> post {get;set;}
        public int UserId { get; set; }
    }
}