using System.Collections.Generic;

namespace MusicCharts.DAL.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AlbumTrack> Tracks { get; set; }
        public List<Genre> Genres { get; set; }
    }
}