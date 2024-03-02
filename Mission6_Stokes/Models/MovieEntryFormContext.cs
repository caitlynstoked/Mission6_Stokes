using Mission6_Stokes.Models;
using Microsoft.EntityFrameworkCore;

namespace Mission6_Stokes.Models
{
    public class MovieEntryFormContext : DbContext
    {
        public MovieEntryFormContext(DbContextOptions<MovieEntryFormContext> options) : base(options)
        {
        }
        //conn movie class to Movies
        public DbSet<MovieEntryForm> Movies { get; set; }
        //conn cat class to cat table 
        public DbSet<Category> Categories { get; set; }
    }
}