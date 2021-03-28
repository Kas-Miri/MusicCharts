using Microsoft.EntityFrameworkCore;
using MusicCharts.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCharts.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Chart> Charts { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
