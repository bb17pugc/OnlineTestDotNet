namespace OnlineExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addall12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Subject", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "Subject");
        }
    }
}
