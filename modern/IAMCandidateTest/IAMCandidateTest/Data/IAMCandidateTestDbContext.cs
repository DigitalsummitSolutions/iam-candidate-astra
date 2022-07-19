using IAMCandidateTest.Models;
using Microsoft.EntityFrameworkCore;
using IAMCandidateTest.Models.ViewModels;

namespace IAMCandidateTest.Data
{
    public class IAMCandidateTestDbContext : DbContext
    {
        public IAMCandidateTestDbContext(DbContextOptions<IAMCandidateTestDbContext> options) : base(options)
        {
        }
        public DbSet<TaxClass> TaxClasses { get; set; }
        public DbSet<TaxFamily> TaxFamilies { get; set; }
        public DbSet<TaxGenus> TaxGenuses { get; set; }
        public DbSet<TaxOrder> TaxOrders { get; set; }
        public DbSet<TaxPhylum> TaxPhylums { get; set; }
        public DbSet<TaxSpecies> TaxSpecies { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Mineral> Minerals { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<EdiblePart> EdibleParts { get; set; }
        public DbSet<Luster> Lusters { get; set; }
        public DbSet<MineralColor> MineralColors { get; set; }
        public DbSet<Streak> Streaks { get; set; }
        public DbSet<Diaphaneity> Diaphaneities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryType>().ToTable("CategoryType");
            modelBuilder.Entity<CategoryType>()
                .HasData(
                   new CategoryType
                   {
                       Id = 1,
                       Name = "Animal"
                   },
                   new CategoryType
                   {
                       Id = 2,
                       Name = "Mineral"
                   },
                   new CategoryType
                   {
                       Id = 3,
                       Name = "Vegetable"
                   }
        );


            modelBuilder.Entity<TaxClass>().ToTable("TaxClass");
            modelBuilder.Entity<TaxClass>().HasData(
                new TaxClass { Id = 1, Name = "Mammalia" },
                new TaxClass { Id = 2, Name = "Aves" },
                new TaxClass { Id = 3, Name = "Insecta" },
                new TaxClass { Id = 4, Name = "Reptilia" }
                );

            modelBuilder.Entity<TaxFamily>().ToTable("TaxFamily");
            modelBuilder.Entity<TaxFamily>().HasData(
                new TaxFamily { Id = 1, Name = "Felidae" },
                new TaxFamily { Id = 2, Name = "Cacatuidae" },
                new TaxFamily { Id = 3, Name = "Struthionidae" },
                new TaxFamily { Id = 4, Name = "Caniformia" },
                new TaxFamily { Id = 5, Name = "Nymphalidae" },
                new TaxFamily { Id = 6, Name = "Colubridae" }
                );


            modelBuilder.Entity<TaxGenus>().ToTable("TaxGenus");
            modelBuilder.Entity<TaxGenus>().HasData(
                new TaxGenus { Id = 1, Name = "Felis" },
                new TaxGenus { Id = 2, Name = "Nymphicus" },
                new TaxGenus { Id = 3, Name = "Struthio" },
                new TaxGenus { Id = 4, Name = "Canis" },
                new TaxGenus { Id = 5, Name = "Danaus" },
                new TaxGenus { Id = 6, Name = "Thamnophis" }
                );

            modelBuilder.Entity<TaxOrder>().ToTable("TaxOrder");
            modelBuilder.Entity<TaxOrder>().HasData(
                new TaxOrder { Id = 1, Name = "Carnivora" },
                new TaxOrder { Id = 2, Name = "Psittaciformes" },
                new TaxOrder { Id = 3, Name = "Struthioniformes" },
                new TaxOrder { Id = 4, Name = "Lepidoptera" },
                new TaxOrder { Id = 5, Name = "Squamata" }
                );

            modelBuilder.Entity<TaxPhylum>().ToTable("TaxPhylum");
            modelBuilder.Entity<TaxPhylum>().HasData(
                new TaxPhylum { Id = 1, Name = "Chordata" },
                new TaxPhylum { Id = 2, Name = "Arthropoda" }
                );

            modelBuilder.Entity<TaxSpecies>().ToTable("TaxSpecies");
            modelBuilder.Entity<TaxSpecies>().HasData(
                new TaxSpecies { Id = 1, Name = "Catus" },
                new TaxSpecies { Id = 2, Name = "Hollandicus" },
                new TaxSpecies { Id = 3, Name = "Camelus" },
                new TaxSpecies { Id = 4, Name = "Familiaris" },
                new TaxSpecies { Id = 5, Name = "Plexippus" },
                new TaxSpecies { Id = 6, Name = "Brachystoma" }
                );

            modelBuilder.Entity<EdiblePart>().ToTable("EdibleParts");
            modelBuilder.Entity<EdiblePart>().HasData(
                new TaxSpecies { Id = 1, Name = "Root" },
                new TaxSpecies { Id = 2, Name = "Fruit" },
                new TaxSpecies { Id = 3, Name = "Leaf" },
                new TaxSpecies { Id = 4, Name = "Seed" },
                new TaxSpecies { Id = 5, Name = "Tuber" }
                );

            modelBuilder.Entity<Luster>().ToTable("Luster");
            modelBuilder.Entity<Luster>().HasData(
                new TaxSpecies { Id = 1, Name = "Metallic" },
                new TaxSpecies { Id = 2, Name = "Adamantine" },
                new TaxSpecies { Id = 3, Name = "Dull" },
                new TaxSpecies { Id = 4, Name = "Vitreous" }
                );

            modelBuilder.Entity<MineralColor>().ToTable("MineralColor");
            modelBuilder.Entity<MineralColor>().HasData(
                new TaxSpecies { Id = 1, Name = "Dull Brown" },
                new TaxSpecies { Id = 2, Name = "Varied" },
                new TaxSpecies { Id = 3, Name = "Golden, yellow" },
                new TaxSpecies { Id = 4, Name = "Reddish Brown" },
                new TaxSpecies { Id = 5, Name = "Clear" }
                );

            modelBuilder.Entity<Streak>().ToTable("Streak");
            modelBuilder.Entity<Streak>().HasData(
                new TaxSpecies { Id = 1, Name = "Metallic copper red" },
                new TaxSpecies { Id = 2, Name = "None" },
                new TaxSpecies { Id = 3, Name = "Golden, yellow" },
                new TaxSpecies { Id = 4, Name = "Red" },
                new TaxSpecies { Id = 5, Name = "Colorless" }
                );

            modelBuilder.Entity<Diaphaneity>().ToTable("Diaphaneity");
            modelBuilder.Entity<Diaphaneity>().HasData(
                new TaxSpecies { Id = 1, Name = "Opaque" },
                new TaxSpecies { Id = 2, Name = "Transparent" }
                );



            modelBuilder.Entity<Animal>().ToTable("Animal");
            //modelBuilder.Entity<Animal>().HasData(
            //    new Animal
            //    {
            //        Id = 1,
            //        Name = "Cat",
            //        LegCount = 4,
            //        WingCount = 0,
            //        CanFly = false,
            //        TaxPhylum = TaxPhylums.Single(tp => tp.Name == "Chordata"),
            //        TaxClass = TaxClasses.Single(tc => tc.Name == "Mammalia"),
            //        TaxOrder = TaxOrders.Single(tc => tc.Name == "Carnivora"),
            //        TaxFamily = TaxFamilies.Single(tf => tf.Name == "Felidae"),
            //        TaxGenus = TaxGenuses.Single(tg => tg.Name == "Felis"),
            //        TaxSpecies = TaxSpecies.Single(ts => ts.Name == "Catus")
            //    }

            //    );


            modelBuilder.Entity<Mineral>().ToTable("Mineral");
            //modelBuilder.Entity<Mineral>().HasData(
            //    new Mineral
            //    {
            //        Id = 1,
            //        Name = "Copper",
            //        Hardness = 2.5M,
            //        Luster = Lusters.Single(l => l.Name == "Metallic"),
            //        Color = MineralColors.Single(mc => mc.Name == "Dull Brown"),
            //        Streak = Streaks.Single(s => s.Name == "Metallic copper red"),
            //        SpecificGravity = 8.90M,
            //        Diaphaneity = Diaphaneities.Single(d => d.Name == "Opaque")
            //    }
            //    );

            modelBuilder.Entity<Vegetable>().ToTable("Vegetable");
            //modelBuilder.Entity<Vegetable>().HasData(
            //    new Vegetable
            //    {
            //        Id = 1,
            //        Name = "Beetroot",
            //        EdiblePart = EdibleParts.Single(ep => ep.Name == "Root"),
            //        IsBotanicalFruit = false
            //    }

            //    );





        }

        public DbSet<IAMCandidateTest.Models.ViewModels.AnimalViewModel>? AnimalViewModel { get; set; }

        public DbSet<IAMCandidateTest.Models.ViewModels.MineralViewModel>? MineralViewModel { get; set; }

        public DbSet<IAMCandidateTest.Models.ViewModels.VegetableViewModel>? VegetableViewModel { get; set; }
    }
}