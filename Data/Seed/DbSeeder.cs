
using Microsoft.EntityFrameworkCore;

namespace Login.Data.Seed
{
    public static class DbSeeder
    {
        public static async Task seedAsync(ApplicationDbcontext context)
        {
            await SeedPermissionAsync(context);
            await SuperSeedPermissionAsync(context);


        }

        private static async Task SuperSeedPermissionAsync(ApplicationDbcontext context)
        {
            foreach(var code in PermissionConstants.All)
            {
                if (!context.permissions.Any(P => P.Code == code))
                {
                    await context.permissions.AddAsync(new Models.Permission
                    {
                        Id = new Guid(code),
                        Code = code,
                        description = code.Replace("-", " ")
                    });

                    
                }
            }
           
        }

        private static async Task SeedPermissionAsync(ApplicationDbcontext context)
        {
           
        }
    }
}
