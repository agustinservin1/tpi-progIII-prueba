﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    UserRole = table.Column<string>(type: "TEXT", nullable: false),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: true),
                    Speciality = table.Column<string>(type: "TEXT", nullable: true),
                    LicenseNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    Doctor_IsAvailable = table.Column<bool>(type: "INTEGER", nullable: true),
                    MedicalInsurance = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Usuarios_Adress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Adress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Appoitments",
                columns: table => new
                {
                    IdAppointment = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Time = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Office = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    DoctorIdUser = table.Column<int>(type: "INTEGER", nullable: true),
                    PatientIdUser = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appoitments", x => x.IdAppointment);
                    table.ForeignKey(
                        name: "FK_Appoitments_Usuarios_DoctorIdUser",
                        column: x => x.DoctorIdUser,
                        principalTable: "Usuarios",
                        principalColumn: "IdUser");
                    table.ForeignKey(
                        name: "FK_Appoitments_Usuarios_PatientIdUser",
                        column: x => x.PatientIdUser,
                        principalTable: "Usuarios",
                        principalColumn: "IdUser");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appoitments_DoctorIdUser",
                table: "Appoitments",
                column: "DoctorIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Appoitments_PatientIdUser",
                table: "Appoitments",
                column: "PatientIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_AddressId",
                table: "Usuarios",
                column: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appoitments");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Adress");
        }
    }
}
