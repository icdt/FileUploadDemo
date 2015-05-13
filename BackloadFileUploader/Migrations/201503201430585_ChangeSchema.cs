namespace BackloadFileUploader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSchema : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Photos", "PhotoFile");
            DropColumn("dbo.Photos", "ImageMimeType");
            DropColumn("dbo.Photos", "Description");
            DropColumn("dbo.Photos", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Photos", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Photos", "Description", c => c.String());
            AddColumn("dbo.Photos", "ImageMimeType", c => c.String());
            AddColumn("dbo.Photos", "PhotoFile", c => c.Binary());
        }
    }
}
