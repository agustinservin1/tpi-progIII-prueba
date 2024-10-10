using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixErrorTableAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appoitments_Usuarios_DoctorId",
                table: "Appoitments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appoitments_Usuarios_PatientId",
                table: "Appoitments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appoitments",
                table: "Appoitments");

            migrationBuilder.RenameTable(
                name: "Appoitments",
                newName: "Appointments");

            migrationBuilder.RenameIndex(
                name: "IX_Appoitments_PatientId",
                table: "Appointments",
                newName: "IX_Appointments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appoitments_DoctorId",
                table: "Appointments",
                newName: "IX_Appointments_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Usuarios_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Usuarios_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Usuarios_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Usuarios_PatientId",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appoitments");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_PatientId",
                table: "Appoitments",
                newName: "IX_Appoitments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appoitments",
                newName: "IX_Appoitments_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appoitments",
                table: "Appoitments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appoitments_Usuarios_DoctorId",
                table: "Appoitments",
                column: "DoctorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appoitments_Usuarios_PatientId",
                table: "Appoitments",
                column: "PatientId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
