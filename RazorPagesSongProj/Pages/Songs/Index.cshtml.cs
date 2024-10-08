using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesSongProj.Data;
using RazorPagesSongProj.Pages.Models;

namespace RazorPagesSongProj.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesSongProj.Data.RazorPagesSongProjContext _context;

        public IndexModel(RazorPagesSongProj.Data.RazorPagesSongProjContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; }

        public async Task OnGetAsync()
        {
            Song = await _context.Song.ToListAsync();
        }
    }
}
