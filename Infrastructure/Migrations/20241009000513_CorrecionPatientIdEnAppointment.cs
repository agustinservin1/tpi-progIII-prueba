using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CorrecionPatientIdEnAppointment : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Appoitments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Appoitments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appoitments_Usuarios_DoctorId",
                table: "Appoitments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appoitments_Usuarios_PatientId",
                table: "Appoitments");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Appoitments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Appoitments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Appoitments_Usuarios_DoctorId",
                table: "Appoitments",
                column: "DoctorId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appoitments_Usuarios_PatientId",
                table: "Appoitments",
                column: "PatientId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
