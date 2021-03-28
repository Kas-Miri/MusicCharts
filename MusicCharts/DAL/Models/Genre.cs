using System.Collections.Generic;

namespace MusicCharts.DAL.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GenreTrack> Tracks { get; set; }
    }
}