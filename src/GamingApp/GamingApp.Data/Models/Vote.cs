using System;
using System.Collections.Generic;
using System.Text;

namespace GamingApp.Data.Models
{
    public class Vote
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string Type { get; set; } // Review, Game, Comment

        public int GameId { get; set; }

        public Game Game { get; set; }

        public int ReviewId { get; set; }

        public Review Review { get; set; }

        public int CommentId { get; set; }

        public Comment Comment { get; set; }

        public bool Value { get; set; }
    }
}
