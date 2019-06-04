namespace MattsBlog.Migrations
{
    using MattsBlog.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MattsBlog.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MattsBlog.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }

            if (!context.Roles.Any(r => r.Name == "Moderator"))
            {
                roleManager.Create(new IdentityRole { Name = "Moderator" });
            }

            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            if (!context.Users.Any(u => u.Email == "mnaylor4122@davidsonccc.edu"))
            {
                userManager.Create(new ApplicationUser
                {
                    Email = "mnaylor4122@davidsonccc.edu",
                    UserName = "mnaylor4122@davidsonccc.edu",
                    FirstName = "Matthew",
                    LastName = "Naylor",
                    DisplayName = "Breeze",
                    ProfilePic = "/ProfilePics/2226.jpeg"
                }, "Superman85");
            }

            var userId = userManager.FindByEmail("mnaylor4122@davidsonccc.edu").Id;
            userManager.AddToRole(userId, "Admin");

            if (!context.Users.Any(u => u.Email == "JasonTwichell@mailinator.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    Email = "JasonTwichell@mailinator.com",
                    UserName = "JasonTwichell@mailinator.com",
                    FirstName = "Jason",
                    LastName = "Twichell",
                    DisplayName = "Guru"
                }, "ABC&123");
            }

            userId = userManager.FindByEmail("JasonTwichell@mailinator.com").Id;
            userManager.AddToRole(userId, "Moderator");





            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
