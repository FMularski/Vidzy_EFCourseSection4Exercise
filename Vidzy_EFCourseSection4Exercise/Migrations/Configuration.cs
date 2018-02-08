namespace Vidzy_EFCourseSection4Exercise.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidzy_EFCourseSection4Exercise.MercuryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidzy_EFCourseSection4Exercise.MercuryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Videos.AddOrUpdate(v => v.Name,
                new Video { Name = "The Last Jedi", ReleaseDate = new DateTime(2017, 12, 14), _Classification = Video.Classification.Platinum, Genre = context.Genres.Single( g => g.Name == "Sci-Fi") },
                new Video { Name = "Rogue One", ReleaseDate = new DateTime(2016, 12, 07), _Classification = Video.Classification.Silver, Genre = context.Genres.Single(g => g.Name == "Sci-Fi") },
                new Video { Name = "The Force Awakens", ReleaseDate = new DateTime(2015, 12, 16), _Classification = Video.Classification.Gold, Genre = context.Genres.Single(g => g.Name == "Sci-Fi") }
                );

        }
    }
}
