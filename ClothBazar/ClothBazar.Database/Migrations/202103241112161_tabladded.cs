namespace ClothBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabladded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.categories", t => t.category_ID)
                .Index(t => t.category_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "category_ID", "dbo.categories");
            DropIndex("dbo.products", new[] { "category_ID" });
            DropTable("dbo.products");
            DropTable("dbo.categories");
        }
    }
}
