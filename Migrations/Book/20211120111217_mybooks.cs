using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineLibrary.Migrations.Book
{
    public partial class mybooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(nullable: true),
                    RevisionNumber = table.Column<string>(nullable: true),
                    Publishdate = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    Authors = table.Column<string>(nullable: true),
                    DateAdded = table.Column<string>(nullable: true),
                    BookGenre = table.Column<string>(nullable: true),
                    BookImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
