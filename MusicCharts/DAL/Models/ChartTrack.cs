using System;

namespace MusicCharts.DAL.Models
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