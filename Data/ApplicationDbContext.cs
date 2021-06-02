using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Documents.Models;
using Microsoft.AspNetCore.Identity;

namespace Documents.Data
{
    public class ApplicationDbContext : IdentityDbContext<
        User,
        IdentityRole<string>,
        string,
        IdentityUserClaim<string>,
        IdentityUserRole<string>,
        IdentityUserLogin<string>,
        IdentityRoleClaim<string>,
        IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EvrakTipi> EvrakTipis { get; set; }
        public DbSet<Evrak> Evraks { get; set; }
        public DbSet<User> Admins { get; set; }
    }
}
