using System;

namespace MusicCharts.Models
{
    public class Chart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public ChartTrack ChartTracks { get; set; }
    }
}