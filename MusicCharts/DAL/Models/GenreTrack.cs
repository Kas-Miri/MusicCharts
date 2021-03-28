using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCharts.DAL.Models
{
    public class GenreTrack
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int TrackId { get; set; }
    }
}
