using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerCenterServer.Migrations
{
    /// <inheritdoc />
    public partial class configInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Id_Person", "Jobtitle", "PersonId" },
                values: new object[] { new Guid("c9cc8903-0313-491d-9c15-03d5dc321e32"), new Guid("00000000-0000-0000-0000-000000000001"), "Admin", null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Address", "Email", "Login", "Name", "Password", "Phone", "Surname" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "", "", "admin", "Admin", "admin", "", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c9cc8903-0313-491d-9c15-03d5dc321e32"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));
        }
    }
}
