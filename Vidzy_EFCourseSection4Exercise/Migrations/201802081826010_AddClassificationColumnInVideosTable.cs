namespace Vidzy_EFCourseSection4Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassificationColumnInVideosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "_Classification", c => c.Byte());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "_Classification");
        }
    }
}
