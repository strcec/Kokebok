namespace Recipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class amount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "Amount", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipes", "Amount");
        }
    }
}
