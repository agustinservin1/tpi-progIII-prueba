﻿using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options, bool isTestingEnviroment = false) : base(options)
        {
        }
        public DbSet<Doctor>Doctors { get; set; }
        public DbSet<Patient>Patients { get; set; }
        public DbSet<Appointment>Appointments { get; set; }
        public DbSet<Address> Adress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasDiscriminator<UserRole>("UserRole")
                .HasValue<Doctor>(UserRole.Doctor)
                .HasValue<Patient>(UserRole.Patient)
                .HasValue<Admin>(UserRole.Admin);

            modelBuilder.Entity<Doctor>()
                .ToTable("Usuarios");

            modelBuilder.Entity<Patient>()
                .ToTable("Usuarios");

            modelBuilder.Entity<User>().ToTable("Usuarios");

            var userRoleConverter = new EnumToStringConverter<UserRole>();
            modelBuilder.Entity<User>()
            .Property(e => e.UserRole)
                .HasConversion(userRoleConverter);

            var appointmetStatusConverter = new EnumToStringConverter<AppointmentStatus>();
            modelBuilder.Entity<Appointment>()
                .Property(e => e.Status)
                .HasConversion(appointmetStatusConverter);

            modelBuilder.Entity<Doctor>()
                .Property(b => b.Specialty)
                .HasConversion(
                    c => c.ToString(),
                    c => Enum.Parse<Specialty>(c)
                );

            modelBuilder.Entity<Doctor>()
                .HasMany(d => d.AssignedAppointment)
                .WithOne(t => t.Doctor);

            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Appoitments)
                .WithOne(a => a.Patient)
                .HasForeignKey(a => a.PatientId);

            modelBuilder.Entity<Patient>()
                .HasOne(u => u.Address)
                .WithOne(a => a.Patient)
                .HasForeignKey<Address>(a => a.PatientId);




        }

    }
}
