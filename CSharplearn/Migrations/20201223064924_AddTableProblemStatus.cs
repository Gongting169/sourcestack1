using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharplearn.Migrations
{
    public partial class AddTableProblemStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProblemStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProblemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProblemStatuses_Contents_ProblemId",
                        column: x => x.ProblemId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProblemStatuses_ProblemId",
                table: "ProblemStatuses",
                column: "ProblemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProblemStatuses");
        }
    }
}
