﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy2
{
    class BlogContext : DbContext
    {
        public DbSet<Post> Posts { set; get; }
        public DbSet<Blog> Blogs { set; get; }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Description)
                .HasColumnName("description_");
        }
    }
}
