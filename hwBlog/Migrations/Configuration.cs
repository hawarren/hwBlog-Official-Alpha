
namespace hwBlog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;


	
    internal sealed class Configuration : DbMigrationsConfiguration<hwBlog.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

    protected override void Seed(ApplicationDbContext context)
    {
        var roleManager = new RoleManager<IdentityRole>(
        new RoleStore<IdentityRole>(context));

        if (!context.Roles.Any(r => r.Name == "Admin"))
        {
            roleManager.Create(new IdentityRole { Name = "Admin" });
        }

        var userManager = new UserManager<ApplicationUser>(
 new UserStore<ApplicationUser>(context));

        if (!context.Users.Any(u => u.Email == "hanifwarren@gmail.com"))
        {
            userManager.Create(new ApplicationUser
            {
                UserName = "hanifwarren@gmail.com",
                Email = "hanifwarren@gmail.com",
                FirstName = "Hanif",
                LastName = "Warren",
                DisplayName = "Hanif Warren"
            }, "12345678");
        }

        var userId = userManager.FindByEmail("hanifwarren@gmail.com").Id;
        userManager.AddToRole(userId, "Admin");
    }

}
}
