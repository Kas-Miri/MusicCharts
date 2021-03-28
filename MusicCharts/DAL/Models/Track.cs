using System;
using System.Collections.Generic;

namespace MusicCharts.DAL.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public List<AuthorTrack> Authors { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public List<GenreTrack> Genres { get; set; }
        public List<ChartTrack> Charts { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
        public byte[] Image { get; set; }
        public string Path { get; set; }
    }
}
