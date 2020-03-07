namespace OnlineExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addall123 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Questions", name: "subject_ID", newName: "subjectId_ID");
            RenameIndex(table: "dbo.Questions", name: "IX_subject_ID", newName: "IX_subjectId_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Questions", name: "IX_subjectId_ID", newName: "IX_subject_ID");
            RenameColumn(table: "dbo.Questions", name: "subjectId_ID", newName: "subject_ID");
        }
    }
}
