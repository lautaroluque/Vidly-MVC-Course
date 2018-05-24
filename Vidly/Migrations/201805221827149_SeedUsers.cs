namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c2bbe0d-90e4-44e1-a113-fe2802466c84', N'guest@vidly.com', 0, N'ALUGQShiZc0fANxGiubMacgMoS+Ii9nnpYDaHqVItMvC7Xf5VU29wF4jWVt7sgentg==', N'dd8d4648-6fca-4f05-9d5b-2b10f3095bff', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fccb1264-92b1-4e0b-bfab-4ad82a876602', N'admin@vidly.com', 0, N'AAFVYUly7lv8dKcWV61Qr6SuBGV9Y3xoKNAEAEcEeAqaQ3hlicro/49FFueSrHSjDA==', N'c3f92faf-b9ae-4008-af3d-3520a40fb27a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9456a11b-76bd-4023-ab56-b58b559d99b5', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fccb1264-92b1-4e0b-bfab-4ad82a876602', N'9456a11b-76bd-4023-ab56-b58b559d99b5')
");

        }
        
        public override void Down()
        {
        }
    }
}
