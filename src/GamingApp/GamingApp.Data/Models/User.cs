using System.Collections.Generic;

namespace GamingApp.Data.Models
{
    public class User
    {
        public User()
        {
            this.ActionHistory = new List<Action>();
            this.FavouriteGames = new List<Game>();
            this.UsersGames = new List<UserGame>();
            this.Votes = new List<Vote>();
        }

        public int Id { get; set; }

        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public byte[] ProfilePic { get; set; }

        public ICollection<Action> ActionHistory { get; set; }

        public ICollection<Game> FavouriteGames { get; set; }

        public ICollection<UserGame> UsersGames { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }
}
