using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineLibrary.Migrations.Book
{
    public partial class checkincheckout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCheckinCheckouts",
                columns: table => new
                {
                    CheckOutId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CheckStatus = table.Column<int>(nullable: false),
                    CheckOutStatus = table.Column<int>(nullable: false),
                    CheckInStatus = table.Column<int>(nullable: false),
                    CheckInDate = table.Column<string>(nullable: true),
                    CheckOutdate = table.Column<string>(nullable: true),
                    readerId = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCheckinCheckouts", x => x.CheckOutId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCheckinCheckouts");
        }
    }
}
