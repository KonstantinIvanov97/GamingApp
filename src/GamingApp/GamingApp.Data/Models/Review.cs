using System;
using System.Collections.Generic;
using System.Text;

namespace GamingApp.Data.Models
{
    public class Review
    {
        public Review()
        {
            this.Comments = new List<Comment>();
            this.Votes = new List<Vote>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string Text { get; set; }

        public DateTime Published { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }
}
