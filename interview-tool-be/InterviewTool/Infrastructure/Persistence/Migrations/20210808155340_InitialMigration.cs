using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewTool.Infrastructure.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    chapter_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.chapter_id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    topic_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<double>(type: "float", nullable: false),
                    chapter_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.topic_id);
                    table.ForeignKey(
                        name: "FK_Topics_Chapters_chapter_id",
                        column: x => x.chapter_id,
                        principalTable: "Chapters",
                        principalColumn: "chapter_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Topics_chapter_id",
                table: "Topics",
                column: "chapter_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Chapters");
        }
    }
}
