using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            // admin: Admin12!@
            // guest: Guest12!@
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2d239d36-def3-4d48-8417-57edce7d028c', N'guest@vidly.com', 0, N'AJ7ZM0SDVWeEMZWbIqGBkutTmZyT+cK+fqLqYcNJSrbU2X5TFUWLkyxPxtE2B3nD9w==', N'130a4119-ff8e-401d-9669-307bfdb17d56', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e4feef4e-5b62-4539-9bf2-81fbdd657c18', N'admin@vidly.com', 0, N'ABvxtNfJCzHmF+jqLCNqpTdlKdmKRy1o4ftXb2Bb73Lnb2IFoOD41VXXbSd1AiWxHA==', N'6dc5cd3b-3b6b-43a8-b95f-36b465a127de', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1a5f18ec-e987-463e-9d9b-522b77b2102a', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e4feef4e-5b62-4539-9bf2-81fbdd657c18', N'1a5f18ec-e987-463e-9d9b-522b77b2102a')
");

        }

        public override void Down()
        {
        }
    }
}