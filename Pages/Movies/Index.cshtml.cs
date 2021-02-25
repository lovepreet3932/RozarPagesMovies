using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RozarPagesMovies.Data;
using RozarPagesMovies.Models;

namespace RozarPagesMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RozarPagesMovies.Data.RozarPagesMoviesContext _context;

        public IndexModel(RozarPagesMovies.Data.RozarPagesMoviesContext context)
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
