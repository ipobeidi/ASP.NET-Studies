namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9fd7c8e6-24d1-433e-83e3-3452ab1c8fce', N'guest@vidly.com', 0, N'AJA9uLGCgG7JfMO92XQkjYZT+IqshbTznK+X877/e3mgqnMPytYJV4sgEcYRVjExfg==', N'f5a4ad06-25b0-4a9d-88eb-948d49063e54', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'efda6573-1566-4186-ab98-20c3cfa9afb1', N'Admin@vidly.com', 0, N'AM43ZS085NS1H76aH12CKJWMLn6FA3jNy0HA9Bhj6k+zPzOSycqKMYl5w6GTF1jYqQ==', N'aec39fa8-f4ea-41b4-80ae-3d29eaf26895', NULL, 0, 0, NULL, 1, 0, N'Admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'01da4d9d-8642-497e-bc3b-8509c3501280', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'efda6573-1566-4186-ab98-20c3cfa9afb1', N'01da4d9d-8642-497e-bc3b-8509c3501280')
");
        }
        
        public override void Down()
        {
        }
    }
}
