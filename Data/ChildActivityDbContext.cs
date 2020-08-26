using KidActivityManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidActivityManagement.Data
{
    public class ChildActivityDbContext:IdentityDbContext<IdentityUser>
    {
        public DbSet<Child> Children { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<ChildActivity> ChildActivites { get; set; }

        public ChildActivityDbContext(DbContextOptions<ChildActivityDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChildActivity>()
                .HasKey(j => new { j.ChildId, j.ActivityId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
