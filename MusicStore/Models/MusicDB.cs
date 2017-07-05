using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MusicStore.Models
{
    public class MusicDB : DbContext
    {
        public DbSet<Music> Musics { get; set; }
    }
}