using SQLite;
using SQLiteNetExtensions.Attributes;

namespace VidyaPlayer.Models
{
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Filename { get; set; }
    }
}