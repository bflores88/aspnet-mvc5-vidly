namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1cf4a73d-39a3-4db1-80d8-b99d3f314e3d', N'guest@vidly.com', 0, N'APbDN9aJP0hJ59cz3OjRxtgTofU75QhRAnH6zOalnXrXY4JZ6HF+W9coWTStzZvoyA==', N'9a112bf0-8dcb-4771-b0bf-2d9f1c6c1286', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'90e6d677-4b5b-438a-8175-ea1a4c8bf4b4', N'admin@vidly.com', 0, N'ABLz2JX5BEEfiHYaOW+PudqnFgSmzGhtxPikM77gkQe/K3WhYPYNasr46hkGi5gFOw==', N'1cd2e279-06e6-4727-8e3d-9ae66d492ae4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'511e4b8f-3104-4e82-aa39-a126d23aecde', N'CanManageMovies')
                ");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90e6d677-4b5b-438a-8175-ea1a4c8bf4b4', N'511e4b8f-3104-4e82-aa39-a126d23aecde')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
