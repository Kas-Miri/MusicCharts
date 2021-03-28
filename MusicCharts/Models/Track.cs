using System;
using System.Collections.Generic;

namespace MusicCharts.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Author> Authors { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Genre> Genres { get; set; }
        public List<ChartTrack> ChartTracks { get; set; }
        public Album Album { get; set; }
        public object Image { get; set; }
        public string Path { get; set; }

    }
}
