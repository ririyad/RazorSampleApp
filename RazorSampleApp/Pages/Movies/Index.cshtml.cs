using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSampleApp.Data;
using RazorSampleApp.Models;

namespace RazorSampleApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorSampleApp.Data.RazorSampleAppContext _context;

        public IndexModel(RazorSampleApp.Data.RazorSampleAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
