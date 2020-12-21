using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharplearn.Migrations
{
    public partial class ReSetAddTableSummary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BCredit",
                table: "Register",
                newName: "EmailId");

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    PublishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    Problem_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeedRemoteHelp = table.Column<bool>(type: "bit", nullable: true),
                    Audit = table.Column<bool>(type: "bit", nullable: true),
                    Reward = table.Column<int>(type: "int", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: true),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_NeedRemoteHelp = table.Column<bool>(type: "bit", nullable: true),
                    ArticleId = table.Column<int>(type: "int", nullable: true),
                    ProblemId = table.Column<int>(type: "int", nullable: true),
                    SuggestId = table.Column<int>(type: "int", nullable: true),
                    Suggest_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Award = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Contents_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contents_Contents_ProblemId",
                        column: x => x.ProblemId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contents_Contents_SuggestId",
                        column: x => x.SuggestId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contents_Register_AuthorName",
                        column: x => x.AuthorName,
                        principalTable: "Register",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contents_Register_UserName",
                        column: x => x.UserName,
                        principalTable: "Register",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Captcha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeyWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyWords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appraises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoterName = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    SuggestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appraises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appraises_Contents_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appraises_Contents_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appraises_Contents_SuggestId",
                        column: x => x.SuggestId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appraises_Register_VoterName",
                        column: x => x.VoterName,
                        principalTable: "Register",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleKeyWord",
                columns: table => new
                {
                    ArticlesId = table.Column<int>(type: "int", nullable: false),
                    KeyWordsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleKeyWord", x => new { x.ArticlesId, x.KeyWordsId });
                    table.ForeignKey(
                        name: "FK_ArticleKeyWord_Contents_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleKeyWord_KeyWords_KeyWordsId",
                        column: x => x.KeyWordsId,
                        principalTable: "KeyWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeyWordProblem",
                columns: table => new
                {
                    KeyWordsId = table.Column<int>(type: "int", nullable: false),
                    ProblemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyWordProblem", x => new { x.KeyWordsId, x.ProblemsId });
                    table.ForeignKey(
                        name: "FK_KeyWordProblem_Contents_ProblemsId",
                        column: x => x.ProblemsId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeyWordProblem_KeyWords_KeyWordsId",
                        column: x => x.KeyWordsId,
                        principalTable: "KeyWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Register_EmailId",
                table: "Register",
                column: "EmailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appraises_ArticleId",
                table: "Appraises",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Appraises_CommentId",
                table: "Appraises",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Appraises_SuggestId",
                table: "Appraises",
                column: "SuggestId");

            migrationBuilder.CreateIndex(
                name: "IX_Appraises_VoterName",
                table: "Appraises",
                column: "VoterName");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleKeyWord_KeyWordsId",
                table: "ArticleKeyWord",
                column: "KeyWordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ArticleId",
                table: "Contents",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_AuthorName",
                table: "Contents",
                column: "AuthorName");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ProblemId",
                table: "Contents",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_SuggestId",
                table: "Contents",
                column: "SuggestId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_UserName",
                table: "Contents",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_KeyWordProblem_ProblemsId",
                table: "KeyWordProblem",
                column: "ProblemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Register_Emails_EmailId",
                table: "Register",
                column: "EmailId",
                principalTable: "Emails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Register_Emails_EmailId",
                table: "Register");

            migrationBuilder.DropTable(
                name: "Appraises");

            migrationBuilder.DropTable(
                name: "ArticleKeyWord");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "KeyWordProblem");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "KeyWords");

            migrationBuilder.DropIndex(
                name: "IX_Register_EmailId",
                table: "Register");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "Register",
                newName: "BCredit");
        }
    }
}
