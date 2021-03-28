using System.Collections.Generic;

namespace MusicCharts.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Genre> Genres { get; set; }
    }
}