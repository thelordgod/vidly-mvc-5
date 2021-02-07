namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) Values (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) Values (2, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) Values (3, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) Values (4, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) Values (5, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) Values (6, 'Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
