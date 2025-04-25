using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiemposDeComida.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "TypeFood",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "ReservationMethods",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TypeFood",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ReservationMethods",
                newName: "Nombre");
        }
    }
}
