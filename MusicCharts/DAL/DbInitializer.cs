using MusicCharts.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCharts.DAL
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(ApplicationContext context)
        {
            if (!context.Tracks.Any())
            {
                context.Tracks.Add(new Track
                {
                    Name = "Pipos",
                    Album = new Album { Name = "AAA" },
                    Duration = TimeSpan.FromSeconds(100),
                    DateCreated = DateTime.Now
                });
            }

            await context.SaveChangesAsync();
        }
    }
}
