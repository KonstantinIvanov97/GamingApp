using System;
using System.Collections.Generic;
using System.Text;

namespace GamingApp.Data.Models
{
    public class Action
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
