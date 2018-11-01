using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.Models;

namespace MovieCatalog.Models
{
    public class MovieCatalogContext : DbContext
    {
        public MovieCatalogContext (DbContextOptions<MovieCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<MovieCatalog.Models.Movie> Movie { get; set; }

        public DbSet<MovieCatalog.Models.Rating> Rating { get; set; }

        public DbSet<MovieCatalog.Models.Writer> Writer { get; set; }
    }
}
