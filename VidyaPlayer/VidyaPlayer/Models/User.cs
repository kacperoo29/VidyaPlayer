using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace VidyaPlayer.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        [OneToMany]
        public List<UserMovies> UserMovies { get; set; }
    }
}