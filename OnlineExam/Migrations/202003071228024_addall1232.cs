namespace OnlineExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addall1232 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subjects", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Subjects", "Time", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subjects", "Time", c => c.String());
            AlterColumn("dbo.Subjects", "Name", c => c.String());
        }
    }
}
