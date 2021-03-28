using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCharts.DAL.Models
{
    public class AlbumTrack
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int TrackId { get; set; }
    }
}
