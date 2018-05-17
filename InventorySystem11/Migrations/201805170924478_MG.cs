namespace InventorySystem11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MG : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Category = c.String(),
                        Shelf = c.String(),
                        Count = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
