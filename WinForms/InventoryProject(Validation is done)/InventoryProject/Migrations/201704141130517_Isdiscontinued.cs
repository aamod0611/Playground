namespace InventoryProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Isdiscontinued : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IsDiscontinueds",
                c => new
                    {
                        IsDiscontinuedID = c.Int(nullable: false, identity: true),
                        IsDiscontinuedOptions = c.String(),
                    })
                .PrimaryKey(t => t.IsDiscontinuedID);
            
            AddColumn("dbo.Products", "IsDiscontinuedID", c => c.Int());
            CreateIndex("dbo.Products", "IsDiscontinuedID");
            AddForeignKey("dbo.Products", "IsDiscontinuedID", "dbo.IsDiscontinueds", "IsDiscontinuedID");
            DropColumn("dbo.Products", "IsDiscontinued");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "IsDiscontinued", c => c.String());
            DropForeignKey("dbo.Products", "IsDiscontinuedID", "dbo.IsDiscontinueds");
            DropIndex("dbo.Products", new[] { "IsDiscontinuedID" });
            DropColumn("dbo.Products", "IsDiscontinuedID");
            DropTable("dbo.IsDiscontinueds");
        }
    }
}
