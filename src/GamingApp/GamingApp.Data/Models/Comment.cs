using System;
using System.Collections.Generic;

namespace GamingApp.Data.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Votes = new List<Vote>();
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string Text { get; set; }

        public DateTime Published { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }
}
