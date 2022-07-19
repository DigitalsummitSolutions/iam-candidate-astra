
using IAMCandidateTest.Data;
using IAMCandidateTest.Models;
using Microsoft.EntityFrameworkCore;

public static class CustomDataSeeder
{
    public static WebApplication SeedData(this WebApplication webApp)
    {
        using (var scope = webApp.Services.CreateScope())
        {
            using (var dbContext = scope.ServiceProvider.GetRequiredService<IAMCandidateTestDbContext>())
            {
                try
                {

                    dbContext.Database.EnsureCreated();

                    List<Animal> animals = new();

                    if (dbContext.Animals.FirstOrDefault(a => a.Name == "Cat") == null)
                    {
                        animals.Add(
                            new Animal
                            {
                                Name = "Cat",
                                LegCount = 4,
                                WingCount = 0,
                                CanFly = false,
                                TaxPhylum = dbContext.TaxPhylums.Single(tp => tp.Name == "Chordata"),
                                TaxClass = dbContext.TaxClasses.Single(tc => tc.Name == "Mammalia"),
                                TaxOrder = dbContext.TaxOrders.Single(tc => tc.Name == "Carnivora"),
                                TaxFamily = dbContext.TaxFamilies.Single(tf => tf.Name == "Felidae"),
                                TaxGenus = dbContext.TaxGenuses.Single(tg => tg.Name == "Felis"),
                                TaxSpecies = dbContext.TaxSpecies.Single(ts => ts.Name == "Catus"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Animal")
                            });
                    }

                    if (dbContext.Animals.FirstOrDefault(a => a.Name == "Cockatiel") == null)
                    {
                        animals.Add(
                            new Animal
                            {
                                Name = "Cockatiel",
                                LegCount = 2,
                                WingCount = 2,
                                CanFly = true,
                                TaxPhylum = dbContext.TaxPhylums.Single(tp => tp.Name == "Chordata"),
                                TaxClass = dbContext.TaxClasses.Single(tc => tc.Name == "Aves"),
                                TaxOrder = dbContext.TaxOrders.Single(tc => tc.Name == "Psittaciformes"),
                                TaxFamily = dbContext.TaxFamilies.Single(tf => tf.Name == "Cacatuidae"),
                                TaxGenus = dbContext.TaxGenuses.Single(tg => tg.Name == "Nymphicus"),
                                TaxSpecies = dbContext.TaxSpecies.Single(ts => ts.Name == "Hollandicus"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Animal")
                            });
                    }

                    if (dbContext.Animals.FirstOrDefault(a => a.Name == "Common ostrich") == null)
                    {
                        animals.Add(
                            new Animal
                            {
                                Name = "Common ostrich",
                                LegCount = 2,
                                WingCount = 2,
                                CanFly = false,
                                TaxPhylum = dbContext.TaxPhylums.Single(tp => tp.Name == "Chordata"),
                                TaxClass = dbContext.TaxClasses.Single(tc => tc.Name == "Aves"),
                                TaxOrder = dbContext.TaxOrders.Single(tc => tc.Name == "Struthioniformes"),
                                TaxFamily = dbContext.TaxFamilies.Single(tf => tf.Name == "Struthionidae"),
                                TaxGenus = dbContext.TaxGenuses.Single(tg => tg.Name == "Struthio"),
                                TaxSpecies = dbContext.TaxSpecies.Single(ts => ts.Name == "Camelus"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Animal")
                            });
                    }


                    if (dbContext.Animals.FirstOrDefault(a => a.Name == "Dog") == null)
                    {
                        animals.Add(
                            new Animal
                            {
                                Name = "Dog",
                                LegCount = 4,
                                WingCount = 0,
                                CanFly = false,
                                TaxPhylum = dbContext.TaxPhylums.Single(tp => tp.Name == "Chordata"),
                                TaxClass = dbContext.TaxClasses.Single(tc => tc.Name == "Mammalia"),
                                TaxOrder = dbContext.TaxOrders.Single(tc => tc.Name == "Carnivora"),
                                TaxFamily = dbContext.TaxFamilies.Single(tf => tf.Name == "Caniformia"),
                                TaxGenus = dbContext.TaxGenuses.Single(tg => tg.Name == "Canis"),
                                TaxSpecies = dbContext.TaxSpecies.Single(ts => ts.Name == "Familiaris"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Animal")
                            });
                    }

                    if (dbContext.Animals.FirstOrDefault(a => a.Name == "Monarch butterfly") == null)
                    {
                        animals.Add(
                            new Animal
                            {
                                Name = "Monarch butterfly",
                                LegCount = 6,
                                WingCount = 4,
                                CanFly = true,
                                TaxPhylum = dbContext.TaxPhylums.Single(tp => tp.Name == "Arthropoda"),
                                TaxClass = dbContext.TaxClasses.Single(tc => tc.Name == "Insecta"),
                                TaxOrder = dbContext.TaxOrders.Single(tc => tc.Name == "Lepidoptera"),
                                TaxFamily = dbContext.TaxFamilies.Single(tf => tf.Name == "Nymphalidae"),
                                TaxGenus = dbContext.TaxGenuses.Single(tg => tg.Name == "Danaus"),
                                TaxSpecies = dbContext.TaxSpecies.Single(ts => ts.Name == "Plexippus"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Animal")
                            });
                    }

                    if (dbContext.Animals.FirstOrDefault(a => a.Name == "Shorthead garter snake") == null)
                    {
                        animals.Add(
                            new Animal
                            {
                                Name = "Shorthead garter snake",
                                LegCount = 0,
                                WingCount = 0,
                                CanFly = false,
                                TaxPhylum = dbContext.TaxPhylums.Single(tp => tp.Name == "Chordata"),
                                TaxClass = dbContext.TaxClasses.Single(tc => tc.Name == "Reptilia"),
                                TaxOrder = dbContext.TaxOrders.Single(tc => tc.Name == "Squamata"),
                                TaxFamily = dbContext.TaxFamilies.Single(tf => tf.Name == "Colubridae"),
                                TaxGenus = dbContext.TaxGenuses.Single(tg => tg.Name == "Thamnophis"),
                                TaxSpecies = dbContext.TaxSpecies.Single(ts => ts.Name == "Brachystoma"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Animal")
                            });
                    }


                    dbContext.Animals.AddRange(animals);

                    List<Mineral> minerals = new();

                    if (dbContext.Minerals.FirstOrDefault(a => a.Name == "Copper") == null)
                    {
                        minerals.Add(
                            new Mineral
                            {
                                Name = "Copper",
                                Hardness = 2.5M,
                                Luster = dbContext.Lusters.Single(l => l.Name == "Metallic"),
                                Color = dbContext.MineralColors.Single(mc => mc.Name == "Dull Brown"),
                                Streak = dbContext.Streaks.Single(s => s.Name == "Metallic copper red"),
                                SpecificGravity = 8.90M,
                                Diaphaneity = dbContext.Diaphaneities.Single(d => d.Name == "Opaque"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Mineral")
                            });
                    }

                    if (dbContext.Minerals.FirstOrDefault(a => a.Name == "Diamond") == null)
                    {
                        minerals.Add(
                            new Mineral
                            {
                                Name = "Diamond",
                                Hardness = 10.0M,
                                Luster = dbContext.Lusters.Single(l => l.Name == "Adamantine"),
                                Color = dbContext.MineralColors.Single(mc => mc.Name == "Varied"),
                                Streak = dbContext.Streaks.Single(s => s.Name == "None"),
                                SpecificGravity = 3.40M,
                                Diaphaneity = dbContext.Diaphaneities.Single(d => d.Name == "Transparent"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Mineral")
                            });
                    }

                    if (dbContext.Minerals.FirstOrDefault(a => a.Name == "Gold") == null)
                    {
                        minerals.Add(
                            new Mineral
                            {
                                Name = "Gold",
                                Hardness = 2.5M,
                                Luster = dbContext.Lusters.Single(l => l.Name == "Metallic"),
                                Color = dbContext.MineralColors.Single(mc => mc.Name == "Golden, yellow"),
                                Streak = dbContext.Streaks.Single(s => s.Name == "Golden, yellow"),
                                SpecificGravity = 19.30M,
                                Diaphaneity = dbContext.Diaphaneities.Single(d => d.Name == "Opaque"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Mineral")
                            });
                    }

                    if (dbContext.Minerals.FirstOrDefault(a => a.Name == "Hematite") == null)
                    {
                        minerals.Add(
                            new Mineral
                            {
                                Name = "Hematite",
                                Hardness = 5.0M,
                                Luster = dbContext.Lusters.Single(l => l.Name == "Dull"),
                                Color = dbContext.MineralColors.Single(mc => mc.Name == "Reddish Brown"),
                                Streak = dbContext.Streaks.Single(s => s.Name == "Red"),
                                SpecificGravity = 5.00M,
                                Diaphaneity = dbContext.Diaphaneities.Single(d => d.Name == "Opaque"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Mineral")
                            });
                    }

                    if (dbContext.Minerals.FirstOrDefault(a => a.Name == "Quartz") == null)
                    {
                        minerals.Add(
                            new Mineral
                            {
                                Name = "Quartz",
                                Hardness = 7.0M,
                                Luster = dbContext.Lusters.Single(l => l.Name == "Vitreous"),
                                Color = dbContext.MineralColors.Single(mc => mc.Name == "Clear"),
                                Streak = dbContext.Streaks.Single(s => s.Name == "Colorless"),
                                SpecificGravity = 2.60M,
                                Diaphaneity = dbContext.Diaphaneities.Single(d => d.Name == "Transparent"),
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Mineral")
                            });
                    }

                    dbContext.Minerals.AddRange(minerals);

                    List<Vegetable> vegetables = new();

                    if (dbContext.Vegetables.FirstOrDefault(a => a.Name == "Beetroot") == null)
                    {
                        vegetables.Add(
                            new Vegetable
                            {
                                Name = "Beetroot",
                                EdiblePart = dbContext.EdibleParts.Single(p => p.Name == "Root"),
                                IsBotanicalFruit = false,
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Vegetable")
                            });
                    }

                    if (dbContext.Vegetables.FirstOrDefault(a => a.Name == "Bell pepper") == null)
                    {
                        vegetables.Add(
                            new Vegetable
                            {
                                Name = "Bell pepper",
                                EdiblePart = dbContext.EdibleParts.Single(p => p.Name == "Fruit"),
                                IsBotanicalFruit = true,
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Vegetable")
                            });
                    }

                    if (dbContext.Vegetables.FirstOrDefault(a => a.Name == "Carrot") == null)
                    {
                        vegetables.Add(
                            new Vegetable
                            {
                                Name = "Carrot",
                                EdiblePart = dbContext.EdibleParts.Single(p => p.Name == "Root"),
                                IsBotanicalFruit = false,
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Vegetable")
                            });
                    }

                    if (dbContext.Vegetables.FirstOrDefault(a => a.Name == "Lettuce") == null)
                    {
                        vegetables.Add(
                            new Vegetable
                            {
                                Name = "Lettuce",
                                EdiblePart = dbContext.EdibleParts.Single(p => p.Name == "Leaf"),
                                IsBotanicalFruit = false,
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Vegetable")
                            });
                    }

                    if (dbContext.Vegetables.FirstOrDefault(a => a.Name == "Lima bean") == null)
                    {
                        vegetables.Add(
                            new Vegetable
                            {
                                Name = "Lima bean",
                                EdiblePart = dbContext.EdibleParts.Single(p => p.Name == "Seed"),
                                IsBotanicalFruit = false,
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Vegetable")
                            });
                    }

                    if (dbContext.Vegetables.FirstOrDefault(a => a.Name == "Potato") == null)
                    {
                        vegetables.Add(
                            new Vegetable
                            {
                                Name = "Potato",
                                EdiblePart = dbContext.EdibleParts.Single(p => p.Name == "Tuber"),
                                IsBotanicalFruit = false,
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Vegetable")
                            });
                    }

                    if (dbContext.Vegetables.FirstOrDefault(a => a.Name == "Tomato") == null)
                    {
                        vegetables.Add(
                            new Vegetable
                            {
                                Name = "Tomato",
                                EdiblePart = dbContext.EdibleParts.Single(p => p.Name == "Fruit"),
                                IsBotanicalFruit = true,
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Vegetable")
                            });
                    }

                    if (dbContext.Vegetables.FirstOrDefault(a => a.Name == "Wheat") == null)
                    {
                        vegetables.Add(
                            new Vegetable
                            {
                                Name = "Wheat",
                                EdiblePart = dbContext.EdibleParts.Single(p => p.Name == "Seed"),
                                IsBotanicalFruit = false,
                                CategoryType = dbContext.CategoryTypes.Single(ct => ct.Name == "Vegetable")
                            });
                    }

                    dbContext.Vegetables.AddRange(vegetables);

                    dbContext.SaveChanges();

                }
                catch (Exception ex)
                {
                    //Log errors or do anything you think it's needed
                    throw;
                }
            }
        }
        return webApp;
    }
}