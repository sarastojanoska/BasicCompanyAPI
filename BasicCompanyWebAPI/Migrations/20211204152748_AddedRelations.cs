using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicCompanyWebAPI.Migrations
{
    public partial class AddedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_contacts_tbl_companies_CompanyId",
                table: "tbl_contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_contacts_tbl_countries_CountryId",
                table: "tbl_contacts");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_contacts_tbl_companies_CompanyId",
                table: "tbl_contacts",
                column: "CompanyId",
                principalTable: "tbl_companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_contacts_tbl_countries_CountryId",
                table: "tbl_contacts",
                column: "CountryId",
                principalTable: "tbl_countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_contacts_tbl_companies_CompanyId",
                table: "tbl_contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_contacts_tbl_countries_CountryId",
                table: "tbl_contacts");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_contacts_tbl_companies_CompanyId",
                table: "tbl_contacts",
                column: "CompanyId",
                principalTable: "tbl_companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_contacts_tbl_countries_CountryId",
                table: "tbl_contacts",
                column: "CountryId",
                principalTable: "tbl_countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
