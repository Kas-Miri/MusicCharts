using System.Collections.Generic;

namespace MusicCharts.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object Photo { get; set; }
        public List<Track> Tracks { get; set; }
    }
}