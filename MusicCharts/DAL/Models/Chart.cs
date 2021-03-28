using System;
using System.Collections.Generic;

namespace MusicCharts.DAL.Models
{
    public class Chart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public List<ChartTrack> Tracks { get; set; }
    }
}