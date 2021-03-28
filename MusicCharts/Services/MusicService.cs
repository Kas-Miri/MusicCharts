using Microsoft.EntityFrameworkCore;
using MusicCharts.DAL;
using MusicCharts.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCharts.Services
{
    public class MusicService
    {
        private readonly ApplicationContext _db;

        public MusicService(ApplicationContext db)
        {
            _db = db;
        }

        public List<Track> GetAllTracks()
        {
            return _db.Tracks.ToList();
        }
    }
}
