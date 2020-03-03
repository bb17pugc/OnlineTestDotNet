using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTest.Data.Migrations
{
    public partial class addfulldetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Marks = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "appearedCandidates",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    candidateID = table.Column<int>(nullable: true),
                    subjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appearedCandidates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_appearedCandidates_candidates_candidateID",
                        column: x => x.candidateID,
                        principalTable: "candidates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_appearedCandidates_subjects_subjectID",
                        column: x => x.subjectID,
                        principalTable: "subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cleareds",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    candidateID = table.Column<int>(nullable: true),
                    subjectID = table.Column<int>(nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cleareds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cleareds_candidates_candidateID",
                        column: x => x.candidateID,
                        principalTable: "candidates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cleareds_subjects_subjectID",
                        column: x => x.subjectID,
                        principalTable: "subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    subjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_questions_subjects_subjectID",
                        column: x => x.subjectID,
                        principalTable: "subjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppearedQuestionsDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtA = table.Column<string>(nullable: true),
                    OtB = table.Column<string>(nullable: true),
                    OtC = table.Column<string>(nullable: true),
                    OtD = table.Column<string>(nullable: true),
                    Correct = table.Column<string>(nullable: true),
                    questionID = table.Column<int>(nullable: true),
                    appearedCandidateID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppearedQuestionsDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AppearedQuestionsDetails_appearedCandidates_appearedCandidateID",
                        column: x => x.appearedCandidateID,
                        principalTable: "appearedCandidates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppearedQuestionsDetails_questions_questionID",
                        column: x => x.questionID,
                        principalTable: "questions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "questionOpts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtA = table.Column<string>(nullable: true),
                    OtB = table.Column<string>(nullable: true),
                    OtC = table.Column<string>(nullable: true),
                    OtD = table.Column<string>(nullable: true),
                    Correct = table.Column<string>(nullable: true),
                    questionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionOpts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_questionOpts_questions_questionID",
                        column: x => x.questionID,
                        principalTable: "questions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_appearedCandidates_candidateID",
                table: "appearedCandidates",
                column: "candidateID");

            migrationBuilder.CreateIndex(
                name: "IX_appearedCandidates_subjectID",
                table: "appearedCandidates",
                column: "subjectID");

            migrationBuilder.CreateIndex(
                name: "IX_AppearedQuestionsDetails_appearedCandidateID",
                table: "AppearedQuestionsDetails",
                column: "appearedCandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_AppearedQuestionsDetails_questionID",
                table: "AppearedQuestionsDetails",
                column: "questionID");

            migrationBuilder.CreateIndex(
                name: "IX_cleareds_candidateID",
                table: "cleareds",
                column: "candidateID");

            migrationBuilder.CreateIndex(
                name: "IX_cleareds_subjectID",
                table: "cleareds",
                column: "subjectID");

            migrationBuilder.CreateIndex(
                name: "IX_questionOpts_questionID",
                table: "questionOpts",
                column: "questionID");

            migrationBuilder.CreateIndex(
                name: "IX_questions_subjectID",
                table: "questions",
                column: "subjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppearedQuestionsDetails");

            migrationBuilder.DropTable(
                name: "cleareds");

            migrationBuilder.DropTable(
                name: "questionOpts");

            migrationBuilder.DropTable(
                name: "appearedCandidates");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "subjects");
        }
    }
}
