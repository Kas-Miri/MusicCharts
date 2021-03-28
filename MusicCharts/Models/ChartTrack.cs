using System;

namespace MusicCharts.Models
{
    public class ChartTrack
    {
        public int Id { get; set; }
        public Track Track { get; set; }
        public Chart Chart { get; set; }
        public int Position { get; set; }
        public DateTime DateCreate { get; set; }
    }
}