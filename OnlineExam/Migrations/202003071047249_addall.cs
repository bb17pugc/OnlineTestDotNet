namespace OnlineExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppearedCandidates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        candidate_ID = c.Int(),
                        subject_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Candidates", t => t.candidate_ID)
                .ForeignKey("dbo.Subjects", t => t.subject_ID)
                .Index(t => t.candidate_ID)
                .Index(t => t.subject_ID);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Education = c.String(),
                        Experience = c.String(),
                        applicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.applicationUser_Id)
                .Index(t => t.applicationUser_Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Marks = c.Int(nullable: false),
                        Time = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AppearedQuestionsDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OtA = c.String(),
                        OtB = c.String(),
                        OtC = c.String(),
                        OtD = c.String(),
                        Correct = c.String(),
                        appearedCandidate_ID = c.Int(),
                        question_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AppearedCandidates", t => t.appearedCandidate_ID)
                .ForeignKey("dbo.Questions", t => t.question_ID)
                .Index(t => t.appearedCandidate_ID)
                .Index(t => t.question_ID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        subject_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Subjects", t => t.subject_ID)
                .Index(t => t.subject_ID);
            
            CreateTable(
                "dbo.Cleareds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        candidate_ID = c.Int(),
                        subject_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Candidates", t => t.candidate_ID)
                .ForeignKey("dbo.Subjects", t => t.subject_ID)
                .Index(t => t.candidate_ID)
                .Index(t => t.subject_ID);
            
            CreateTable(
                "dbo.QuestionOpts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OtA = c.String(),
                        OtB = c.String(),
                        OtC = c.String(),
                        OtD = c.String(),
                        Correct = c.String(),
                        question_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Questions", t => t.question_ID)
                .Index(t => t.question_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuestionOpts", "question_ID", "dbo.Questions");
            DropForeignKey("dbo.Cleareds", "subject_ID", "dbo.Subjects");
            DropForeignKey("dbo.Cleareds", "candidate_ID", "dbo.Candidates");
            DropForeignKey("dbo.AppearedQuestionsDetails", "question_ID", "dbo.Questions");
            DropForeignKey("dbo.Questions", "subject_ID", "dbo.Subjects");
            DropForeignKey("dbo.AppearedQuestionsDetails", "appearedCandidate_ID", "dbo.AppearedCandidates");
            DropForeignKey("dbo.AppearedCandidates", "subject_ID", "dbo.Subjects");
            DropForeignKey("dbo.AppearedCandidates", "candidate_ID", "dbo.Candidates");
            DropForeignKey("dbo.Candidates", "applicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.QuestionOpts", new[] { "question_ID" });
            DropIndex("dbo.Cleareds", new[] { "subject_ID" });
            DropIndex("dbo.Cleareds", new[] { "candidate_ID" });
            DropIndex("dbo.Questions", new[] { "subject_ID" });
            DropIndex("dbo.AppearedQuestionsDetails", new[] { "question_ID" });
            DropIndex("dbo.AppearedQuestionsDetails", new[] { "appearedCandidate_ID" });
            DropIndex("dbo.Candidates", new[] { "applicationUser_Id" });
            DropIndex("dbo.AppearedCandidates", new[] { "subject_ID" });
            DropIndex("dbo.AppearedCandidates", new[] { "candidate_ID" });
            DropTable("dbo.QuestionOpts");
            DropTable("dbo.Cleareds");
            DropTable("dbo.Questions");
            DropTable("dbo.AppearedQuestionsDetails");
            DropTable("dbo.Subjects");
            DropTable("dbo.Candidates");
            DropTable("dbo.AppearedCandidates");
        }
    }
}
