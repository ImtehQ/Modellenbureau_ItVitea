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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<ModelUser> ModelUsers {get;set;}
		public DbSet<Photo> Photos {get;set;}
    }
}
