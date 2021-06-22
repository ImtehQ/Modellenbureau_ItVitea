using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Modellenbureau.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modellenbureau.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ModelUser> ModelUsers { get; set; }
        public DbSet<Photo> Photos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
