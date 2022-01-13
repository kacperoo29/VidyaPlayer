using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace VidyaPlayer.Models
{
    public class UserMovies
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(User))]
        public int UserId { get; set; }
        [ForeignKey(typeof(Movie))]
        public int MovieId { get; set; }
        [ManyToOne]
        public Movie Movie { get; set; }
        public int TimesWatched { get; set; }
    }
}