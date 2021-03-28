using System.Collections.Generic;

namespace MusicCharts.DAL.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public List<AuthorTrack> Tracks { get; set; }
    }
}