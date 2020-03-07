namespace OnlineExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addall1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuestionOpts", "Option", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "Education", c => c.String(nullable: false));
            AlterColumn("dbo.Candidates", "Experience", c => c.String(nullable: false));
            AlterColumn("dbo.Questions", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.QuestionOpts", "Correct", c => c.String(nullable: false));
            DropColumn("dbo.QuestionOpts", "OtA");
            DropColumn("dbo.QuestionOpts", "OtB");
            DropColumn("dbo.QuestionOpts", "OtC");
            DropColumn("dbo.QuestionOpts", "OtD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuestionOpts", "OtD", c => c.String());
            AddColumn("dbo.QuestionOpts", "OtC", c => c.String());
            AddColumn("dbo.QuestionOpts", "OtB", c => c.String());
            AddColumn("dbo.QuestionOpts", "OtA", c => c.String());
            AlterColumn("dbo.QuestionOpts", "Correct", c => c.String());
            AlterColumn("dbo.Questions", "Name", c => c.String());
            AlterColumn("dbo.Candidates", "Experience", c => c.String());
            AlterColumn("dbo.Candidates", "Education", c => c.String());
            AlterColumn("dbo.Candidates", "City", c => c.String());
            AlterColumn("dbo.Candidates", "Address", c => c.String());
            AlterColumn("dbo.Candidates", "Phone", c => c.String());
            AlterColumn("dbo.Candidates", "Name", c => c.String());
            DropColumn("dbo.QuestionOpts", "Option");
        }
    }
}
