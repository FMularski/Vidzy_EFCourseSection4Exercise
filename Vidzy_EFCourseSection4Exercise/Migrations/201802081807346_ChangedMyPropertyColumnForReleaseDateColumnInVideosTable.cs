namespace Vidzy_EFCourseSection4Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMyPropertyColumnForReleaseDateColumnInVideosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Videos", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Videos", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Videos", "ReleaseDate");
        }
    }
}
