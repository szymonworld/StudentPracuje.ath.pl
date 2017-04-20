using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Pracuj.Models;

namespace studentpracuje.ath.bielsko.pl
{
    public class EntityDatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employer> Employers { get; set; }

        public EntityDatabaseContext() : base("PracujContext")
        {
            Database.SetInitializer<EntityDatabaseContext>(new DropCreateDatabaseAlways<EntityDatabaseContext>());
        }

    }
}