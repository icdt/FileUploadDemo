namespace BackloadFileUploader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSchema2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Photos", "IsPublish", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Photos", "IsPublish");
        }
    }
}
