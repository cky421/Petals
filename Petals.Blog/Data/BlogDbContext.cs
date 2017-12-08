using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Petals.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petals.Blog.Data
{
    public class BlogDbContext : IdentityDbContext<User>
    {

        public DbSet<User> User { get; set; }
        public DbSet<Models.Blog> Blog { get; set; }
        public DbSet<Models.BlogCategory> BlogCategory { get; set; }
        public DbSet<Models.BlogTag> BlogTag { get; set; }
        public DbSet<Models.Tag> Tag { get; set; }
        public DbSet<Models.Category> Category { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
