namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludeGenresAndPropertys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "ReleasedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddData", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Genres_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Genres_Id");
            AddForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_Id" });
            DropColumn("dbo.Movies", "Genres_Id");
            DropColumn("dbo.Movies", "Quantity");
            DropColumn("dbo.Movies", "AddData");
            DropColumn("dbo.Movies", "ReleasedDate");
            DropTable("dbo.Genres");
        }
    }
}
