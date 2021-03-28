namespace MusicCharts.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Track Tracks { get; set; }
    }
}