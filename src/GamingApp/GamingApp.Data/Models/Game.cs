using System;
using System.Collections.Generic;
using System.Text;

namespace GamingApp.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.Reviews = new List<Review>();
            this.Comments = new List<Comment>();
            this.Votes = new List<Vote>();
            this.UsersGames = new List<UserGame>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public byte[] Picture { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<Review> Reviews { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Vote> Votes { get; set; }

        public List<UserGame> UsersGames { get; set; }
    }
}
