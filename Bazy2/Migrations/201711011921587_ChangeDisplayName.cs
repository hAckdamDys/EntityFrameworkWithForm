namespace Bazy2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDisplayName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "Description", newName: "description_");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Users", name: "description_", newName: "Description");
        }
    }
}
