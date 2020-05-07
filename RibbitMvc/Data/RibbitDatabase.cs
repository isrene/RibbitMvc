﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RibbitMvc.Models;

namespace RibbitMvc.Data
{
    public class RibbitDatabase: DbContext
    {

        public RibbitDatabase() : base("RibbitConnection") { }

        public DbSet<User> Users{ get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Ribbit> Ribbit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Followers)
                .WithMany(u => u.Followings)
                .Map(
                    map =>
                    {
                        map.MapLeftKey("FollowingId");
                        map.MapRightKey("FollowerId");
                        map.ToTable("Follow");
                    }
                );


            modelBuilder.Entity<User>()
                .HasMany(u => u.Ribbits);
              

            base.OnModelCreating(modelBuilder);
        }
    }
}