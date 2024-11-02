using Medlatec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

public class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public ApplicationDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed dữ liệu cho Patient
        modelBuilder.Entity<Patient>().HasData(
            new Patient { Id = 1, Name = "Nguyen Van A", PhoneNumber = "0123456789", Email = "nguyenvana@example.com" },
            new Patient { Id = 2, Name = "Tran Thi B", PhoneNumber = "0987654321", Email = "tranthib@example.com" }
        );

        // Seed dữ liệu cho Appointment
        modelBuilder.Entity<Appointment>().HasData(
            new Appointment
            {
                Id = 1,
                PatientId = 1, // Giả sử PatientId 1 tương ứng với Nguyen Van A
                AppointmentDate = DateTime.Now.AddDays(1),
                DoctorName = "Dr. Smith",
                Status = "Pending" // Cung cấp giá trị cho Status
            },
            new Appointment
            {
                Id = 2,
                PatientId = 2, // Giả sử PatientId 2 tương ứng với Tran Thi B
                AppointmentDate = DateTime.Now.AddDays(2),
                DoctorName = "Dr. Jones",
                Status = "Confirmed" // Cung cấp giá trị cho Status
            }
        );
    }


}
