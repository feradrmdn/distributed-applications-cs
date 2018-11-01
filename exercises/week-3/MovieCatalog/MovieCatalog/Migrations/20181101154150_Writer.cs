using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCatalog.Migrations
{
    public partial class Writer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "Movie",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Writer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 150, nullable: false),
                    LastName = table.Column<string>(maxLength: 150, nullable: false),
                    UserName = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_WriterId",
                table: "Movie",
                column: "WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Writer_WriterId",
                table: "Movie",
                column: "WriterId",
                principalTable: "Writer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Writer_WriterId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Writer");

            migrationBuilder.DropIndex(
                name: "IX_Movie_WriterId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "Movie");
        }
    }
}
