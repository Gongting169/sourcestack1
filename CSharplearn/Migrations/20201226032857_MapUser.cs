using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharplearn.Migrations
{
    public partial class MapUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_InvitedById",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BCredit",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Reward",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Register");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Register",
                newName: "UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_InvitedById",
                table: "Register",
                newName: "IX_Register_InvitedById");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Register",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InvitedCode",
                table: "Register",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Register",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Register",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Register",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Register",
                table: "Register",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BMoney",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddMinus = table.Column<int>(type: "int", nullable: false),
                    Usable = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frozen = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMoney", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BMoney_Register_UserId",
                        column: x => x.UserId,
                        principalTable: "Register",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddMinus = table.Column<int>(type: "int", nullable: false),
                    Residual = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BPoints_Register_UserId",
                        column: x => x.UserId,
                        principalTable: "Register",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    PublishTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Register_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Register",
                        principalColumn: "Id",
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
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_Contents_Id",
                        column: x => x.Id,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestUpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NeedRemoteHelp = table.Column<bool>(type: "bit", nullable: false),
                    Audit = table.Column<bool>(type: "bit", nullable: false),
                    Reward = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Problems_Contents_Id",
                        column: x => x.Id,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suggests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Award = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suggests_Contents_Id",
                        column: x => x.Id,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Summaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Summaries_Contents_Id",
                        column: x => x.Id,
                        principalTable: "Contents",
                        principalColumn: "Id",
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
                        name: "FK_ArticleKeyWord_Articles_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Articles",
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
                        name: "FK_KeyWordProblem_KeyWords_KeyWordsId",
                        column: x => x.KeyWordsId,
                        principalTable: "KeyWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeyWordProblem_Problems_ProblemsId",
                        column: x => x.ProblemsId,
                        principalTable: "Problems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProblemStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProblemId = table.Column<int>(type: "int", nullable: false),
                    ProblemId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProblemStatuses_Problems_ProblemId",
                        column: x => x.ProblemId,
                        principalTable: "Problems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProblemStatuses_Problems_ProblemId1",
                        column: x => x.ProblemId1,
                        principalTable: "Problems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeedRemoteHelp = table.Column<bool>(type: "bit", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: true),
                    ProblemId = table.Column<int>(type: "int", nullable: true),
                    SuggestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Contents_Id",
                        column: x => x.Id,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Problems_ProblemId",
                        column: x => x.ProblemId,
                        principalTable: "Problems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Suggests_SuggestId",
                        column: x => x.SuggestId,
                        principalTable: "Suggests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appraises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoterId = table.Column<int>(type: "int", nullable: true),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    SuggestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appraises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appraises_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appraises_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appraises_Register_VoterId",
                        column: x => x.VoterId,
                        principalTable: "Register",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appraises_Suggests_SuggestId",
                        column: x => x.SuggestId,
                        principalTable: "Suggests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Register_EmailId",
                table: "Register",
                column: "EmailId",
                unique: true,
                filter: "[EmailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Register_UserName",
                table: "Register",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.AddCheckConstraint(
                name: "CK_CreateTime",
                table: "Register",
                sql: "CreateTime >= '2020/1/1'");

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
                name: "IX_Appraises_VoterId",
                table: "Appraises",
                column: "VoterId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleKeyWord_KeyWordsId",
                table: "ArticleKeyWord",
                column: "KeyWordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BMoney_UserId",
                table: "BMoney",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BPoints_UserId",
                table: "BPoints",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProblemId",
                table: "Comments",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SuggestId",
                table: "Comments",
                column: "SuggestId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_AuthorId",
                table: "Contents",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyWordProblem_ProblemsId",
                table: "KeyWordProblem",
                column: "ProblemsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProblemStatuses_ProblemId",
                table: "ProblemStatuses",
                column: "ProblemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProblemStatuses_ProblemId1",
                table: "ProblemStatuses",
                column: "ProblemId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Register_Emails_EmailId",
                table: "Register",
                column: "EmailId",
                principalTable: "Emails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Register_Register_InvitedById",
                table: "Register",
                column: "InvitedById",
                principalTable: "Register",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Register_Emails_EmailId",
                table: "Register");

            migrationBuilder.DropForeignKey(
                name: "FK_Register_Register_InvitedById",
                table: "Register");

            migrationBuilder.DropTable(
                name: "Appraises");

            migrationBuilder.DropTable(
                name: "ArticleKeyWord");

            migrationBuilder.DropTable(
                name: "BMoney");

            migrationBuilder.DropTable(
                name: "BPoints");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "KeyWordProblem");

            migrationBuilder.DropTable(
                name: "ProblemStatuses");

            migrationBuilder.DropTable(
                name: "Summaries");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "KeyWords");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.DropTable(
                name: "Suggests");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Register",
                table: "Register");

            migrationBuilder.DropIndex(
                name: "IX_Register_EmailId",
                table: "Register");

            migrationBuilder.DropIndex(
                name: "IX_Register_UserName",
                table: "Register");

            migrationBuilder.DropCheckConstraint(
                name: "CK_CreateTime",
                table: "Register");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Register");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Register");

            migrationBuilder.RenameTable(
                name: "Register",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Register_InvitedById",
                table: "Users",
                newName: "IX_Users_InvitedById");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InvitedCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BCredit",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Reward",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_InvitedById",
                table: "Users",
                column: "InvitedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
