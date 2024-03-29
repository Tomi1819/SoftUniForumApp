﻿namespace ForumApp.Infrastructure.Data
{
    using ForumApp.Infrastructure.Data.Configuration;
    using ForumApp.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Post> Posts { get; set; }
    }
}
