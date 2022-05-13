namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Unitprice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Unitprice");
        }
    }
}
