namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'760571e1-a7d6-475c-a501-4aa0232dca6f', N'guest@vidly.com', 0, N'ABU8jKULhHxc5L4em8jyMMb7F3x3dvg0O2Ez30CLkIImtAPNRzZmW6pRXlO5Rfakvw==', N'25a06592-f57f-4726-8e4c-a1380d587a49', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'76de6184-df88-4a2d-8459-0cc79b96085f', N'admin@vidly.com', 0, N'AEkxKzXfGbCiRSS0LIWnTVLagkpADyPTAOSLQFLL1gNDYoLUKD63CJtn9pZbR6D5Ow==', N'65f8c411-8fb9-45b8-9835-27ff0eeed3e4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6eb01e2d-76e0-4983-b5bd-d16be2486103', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'76de6184-df88-4a2d-8459-0cc79b96085f', N'6eb01e2d-76e0-4983-b5bd-d16be2486103')

");
        }
        
        public override void Down()
        {
        }
    }
}
