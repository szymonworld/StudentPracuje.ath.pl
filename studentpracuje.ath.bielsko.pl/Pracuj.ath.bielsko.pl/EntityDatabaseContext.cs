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
        public DbSet<PostDuration> PostDuration { get; set; }
        public DbSet<LvlOfEmployment> LvlOfEmployment { get; set; }
        public DbSet<JobCategories> JobCategories { get; set; }
        public DbSet<ContractTypes> ContractTypes { get; set; }
        public DbSet<ExperienceTypes> ExperienceTypes { get; set; }


        public EntityDatabaseContext()
            : base("PracujContext")
        {
            Database.SetInitializer<EntityDatabaseContext>(new PracujInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOptional(x => x.CV)
               .WithMany();

            modelBuilder.Entity<CV>().HasRequired(x => x.Student)
               .WithMany()
               .HasForeignKey(x => x.Student_Id);

            base.OnModelCreating(modelBuilder);
        }
    }

    public class PracujInitializer : DropCreateDatabaseIfModelChanges<EntityDatabaseContext>
    {
        protected override void Seed(EntityDatabaseContext context)
        {
            base.Seed(context);

            List<string> JobCategories = new List<string>() {
               "Administracja biurowa",
               "Administracja Państwowa",
               "Agencje doradztwa personalnego",
               "Analiza",
               "Architektura",
               "Badania i rozwój",
               "Budownictwo/Geodezja",
               "Doradztwo/Konsulting",
               "Energetyka",
               "Farmaceutyka/Biotechnologia",
               "Finanse/Ekonomia",
               "Grafika/Kreacja artystyczna/Fotografia",
               "Hotelarstwo/Turystyka/Katering",
               "Human Resources",
               "Informatyka/Administracja",
               "Informatyka/Programowanie",
               "Inne",
               "Instalacja/Utrzymanie/Serwis",
               "Internet/E-Commerce",
               "Inżynieria/Konstrukcje/Technologia",
               "Kadra zarządzająca",
               "Kontrola jakości",
               "Księgowość/Audyt/Podatki",
               "Logistyka/Spedycja/Dystrybucja",
               "Marketing/Reklama/Public Relations",
               "Media/Sztuka/Rozrywka",
               "Nieruchomości/Budownictwo",
               "Obsługa klienta/Call Center",
               "Organizacje pozarządowe/Wolontariat",
               "Praca fizyczna",
               "Pracownik ochrony",
               "Praktyki",
               "Prawo",
               "Produkcja",
               "Projektowanie/Wdrażanie",
               "Rolnictwo/Ochrona środowiska",
               "Służba zdrowia",
               "Sport/Rekreacja",
               "Sprzedaż",
               "Staże",
               "Szkolenia/Edukacja",
               "Telekomunikacja",
               "Tłumaczenia",
               "Ubezpieczenia",
               "Zakupy"
            };

            foreach (var item in JobCategories)
            {
                context.JobCategories.Add(new JobCategories { Name = item });
            }

            List<string> ContractType = new List<string>()
            {
                "Praca Stała",
                "Praca Dodatkowa",
                "Praca Sezonowa",
                "Praca Tymczasowa",
                "Umowa na okres próbny",
                "Umowa o dzieło",
                "Umowa zlecenia",
                "Praktyka",
                "Staż",
                "Chałupnictwo",
                "inna"
            };

            foreach (var item in ContractType)
            {
                context.ContractTypes.Add(new ContractTypes { Name = item });
            }

            List<string> ExperienceType = new List<string>()
            {
                "Brak",
                "0.5 Roku",
                "1 Rok",
                "2 Lata",
                "3 Lata",
                "5 Lat",
                "Ponad 5 Lat"
            };

            foreach (var item in ExperienceType)
            {
                context.ExperienceTypes.Add(new ExperienceTypes { Name = item });
            }

            List<string> LvlOfEmployment = new List<string>()
            {
                "od 1 do 10 prac.",
                "od 11 do 50 prac.",
                "od 51 do 100 prac.",
                "od 101 do 200 prac.",
                "od 201 do 500 prac.",
                "od 501 do 1000 prac.",
                "Ponad 1000 prac."
            };

            foreach (var item in LvlOfEmployment)
            {
                context.LvlOfEmployment.Add(new LvlOfEmployment { Name = item });
            }

            List<string> PostDuration = new List<string>()
            {
                "7 dni",
                "14 dni",
                "30 dni"
            };

            foreach (var item in PostDuration)
            {
                context.PostDuration.Add(new PostDuration { Name = item });
            }

            context.SaveChanges();
        }
    }

}