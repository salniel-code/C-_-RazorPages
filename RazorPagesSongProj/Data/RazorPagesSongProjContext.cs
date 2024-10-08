using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesSongProj.Pages.Models;

namespace RazorPagesSongProj.Data
{
    public class RazorPagesSongProjContext : DbContext
    {
        public RazorPagesSongProjContext (DbContextOptions<RazorPagesSongProjContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesSongProj.Pages.Models.Song> Song { get; set; }
    }
}
