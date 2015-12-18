using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace faketwitter.Models
{
    public class Follower
    {
        public List<User> Users { get; set; }
        public int FollowerId { get; set; }
    }
}