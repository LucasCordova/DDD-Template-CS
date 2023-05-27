using App.Core.Constants;
using App.Infrastructure.Data.Identity.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Data.Identity;

public class AppIdentityDbContextSeed
{
   public static async Task SeedAsync(AppIdentityDbContext identityDbContext, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
    {

        if (identityDbContext.Database.IsSqlServer())
        {
            identityDbContext.Database.Migrate();
        }

        await roleManager.CreateAsync(new IdentityRole(Constants.Roles.Administrators));

        var defaultUser = new AppUser { UserName = "demouser@microsoft.com", Email = "demouser@microsoft.com" };
        await userManager.CreateAsync(defaultUser, AuthorizationConstants.DEFAULT_PASSWORD);

        string adminUserName = "admin@microsoft.com";
        var adminUser = new AppUser { UserName = adminUserName, Email = adminUserName };
        await userManager.CreateAsync(adminUser, AuthorizationConstants.DEFAULT_PASSWORD);
        adminUser = await userManager.FindByNameAsync(adminUserName);
        if (adminUser != null)
        {
            await userManager.AddToRoleAsync(adminUser, Constants.Roles.Administrators);
        }
    }
}
