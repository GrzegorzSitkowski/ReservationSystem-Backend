using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservationSystem.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "SalonId", "UserId" },
                values: new object[] { new Guid("33333333-3333-3333-3333-333333333333"), new Guid("11111111-1111-1111-1111-111111111111"), new Guid("22222222-2222-2222-2222-222222222222") });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "EndTime", "Notes", "SalonId", "ServiceId", "StartTime", "Status" },
                values: new object[] { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("33333333-3333-3333-3333-333333333333"), new DateTimeOffset(new DateTime(2026, 10, 1, 14, 17, 26, 526, DateTimeKind.Unspecified).AddTicks(6465), new TimeSpan(0, 2, 0, 0, 0)), "Please be on time.", new Guid("11111111-1111-1111-1111-111111111111"), new Guid("66666666-6666-6666-6666-666666666666"), new DateTimeOffset(new DateTime(2026, 10, 1, 13, 17, 26, 523, DateTimeKind.Unspecified).AddTicks(1134), new TimeSpan(0, 2, 0, 0, 0)), 0 });

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "IsActive", "Name", "OwnerId", "PhoneNumber", "UpdatedAt" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), "Hetmańska 15, Poznań", new DateTimeOffset(new DateTime(2026, 9, 30, 11, 17, 26, 526, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 0, 0, 0, 0)), "Barber shop.", "xyz@gmail.com", true, "Salon XYZ", new Guid("22222222-2222-2222-2222-222222222222"), "123-456-789", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Duration", "IsActive", "Name", "Price", "SalonId" },
                values: new object[] { new Guid("66666666-6666-6666-6666-666666666666"), "Czas ok. 30 min.", new TimeSpan(0, 0, 30, 0, 0), true, "Strzyżenie krótkich włosów.", 30.00m, new Guid("11111111-1111-1111-1111-111111111111") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));
        }
    }
}
