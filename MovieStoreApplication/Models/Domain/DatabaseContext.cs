﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieStoreApplication.Models.Domain;
namespace MovieStoreApplication.Models.Domain
{
    
        public class DatabaseContext : IdentityDbContext<ApplicationUser>
        {
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {

            }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<Movie> Movie { get; set; }

    }
}
