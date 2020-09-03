using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace VishalMvcMovie.Data
{
    public class VishalMvcMovieContext : DbContext
    {
        public VishalMvcMovieContext (DbContextOptions<VishalMvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
