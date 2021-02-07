namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5df1bd61-ecd1-417c-9c34-f63f87ddb051', N'admin@vidly.com', 0, N'AN9goaMgKIlhce/EryVsaD71Ma6KL+BCpDdYiGnPiHUfT5R2boH3ZyTsMZqVJ94WOQ==', N'6afdcae0-b961-4940-bef1-ac73b5e16414', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f5c8b318-71f8-457c-ac36-d7577edc19ee', N'guest@vidly.com', 0, N'AIjPAOgiuxY4cS3i0cwsAuRY0TmI/qsDoy+8BaA4dwJ1U6VDxlbBm2cpp5+SC1RC+Q==', N'9d701d25-2df7-4bb4-a75c-bd4acb2512ab', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a51d3ac7-d4f9-441e-b108-e9552586f506', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5df1bd61-ecd1-417c-9c34-f63f87ddb051', N'a51d3ac7-d4f9-441e-b108-e9552586f506')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
