using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class final101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceID",
                table: "Services",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "HeadID",
                table: "Head",
                newName: "HeadId");

            migrationBuilder.RenameColumn(
                name: "MessageID",
                table: "Contact",
                newName: "MessageId");

            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "About",
                newName: "AboutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Services",
                newName: "ServiceID");

            migrationBuilder.RenameColumn(
                name: "HeadId",
                table: "Head",
                newName: "HeadID");

            migrationBuilder.RenameColumn(
                name: "MessageId",
                table: "Contact",
                newName: "MessageID");

            migrationBuilder.RenameColumn(
                name: "AboutId",
                table: "About",
                newName: "AboutID");
        }
    }
}
