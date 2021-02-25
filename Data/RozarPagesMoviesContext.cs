using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RozarPagesMovies.Models;

namespace RozarPagesMovies.Data
{
    public class RozarPagesMoviesContext : DbContext
    {
        public RozarPagesMoviesContext (DbContextOptions<RozarPagesMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<RozarPagesMovies.Models.Movie> Movie { get; set; }
    }
}
