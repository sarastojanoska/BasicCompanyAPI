using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicCompanyWebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_tbl_contacts_tbl_companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tbl_companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_contacts_tbl_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "tbl_countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_contacts_CompanyId",
                table: "tbl_contacts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_contacts_CountryId",
                table: "tbl_contacts",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_contacts");

            migrationBuilder.DropTable(
                name: "tbl_companies");

            migrationBuilder.DropTable(
                name: "tbl_countries");
        }
    }
}
