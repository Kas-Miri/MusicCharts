using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCharts.DAL.Models
{
    public class AuthorTrack
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int TrackId { get; set; }
    }
}
