using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirBnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class removecategorydataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 6, 23, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4051), new DateTime(2024, 6, 24, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 20, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4055), new DateTime(2024, 6, 25, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 21, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 6, 26, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 6, 27, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 6, 28, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4070), new DateTime(2024, 6, 29, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 25, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4073), new DateTime(2024, 6, 30, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 26, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 7, 1, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 7, 2, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 7, 3, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 29, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 7, 4, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 30, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 7, 5, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 1, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 7, 6, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4099), new DateTime(2024, 7, 7, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 7, 8, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 7, 9, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 5, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4110), new DateTime(2024, 7, 10, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 6, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4114), new DateTime(2024, 7, 11, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4118), new DateTime(2024, 7, 12, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(3997), new DateTime(2024, 6, 23, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4161), new DateTime(2024, 6, 23, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 6, 24, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 20, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4168), new DateTime(2024, 6, 25, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 21, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 6, 26, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4175), new DateTime(2024, 6, 27, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 6, 28, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 6, 29, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 25, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 6, 30, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 26, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 7, 1, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4243), new DateTime(2024, 7, 2, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 7, 3, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 29, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4250), new DateTime(2024, 7, 4, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 30, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 7, 5, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 1, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 7, 6, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4264), new DateTime(2024, 7, 7, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 7, 8, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4271), new DateTime(2024, 7, 9, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 5, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4274), new DateTime(2024, 7, 10, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 6, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4278), new DateTime(2024, 7, 11, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4281), new DateTime(2024, 7, 12, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4156), new DateTime(2024, 6, 23, 15, 56, 56, 782, DateTimeKind.Local).AddTicks(4158) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2842), new DateTime(2024, 6, 23, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 6, 24, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 20, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2851), new DateTime(2024, 6, 25, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 21, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2854), new DateTime(2024, 6, 26, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 22, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2858), new DateTime(2024, 6, 27, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 23, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2862), new DateTime(2024, 6, 28, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 6, 29, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2869), new DateTime(2024, 6, 30, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 26, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 7, 1, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2878), new DateTime(2024, 7, 2, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 7, 3, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 29, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 7, 4, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 30, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 7, 5, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 1, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2893), new DateTime(2024, 7, 6, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 2, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 7, 7, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 3, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2900), new DateTime(2024, 7, 8, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 7, 9, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 5, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2908), new DateTime(2024, 7, 10, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 7, 11, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 7, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 7, 12, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2781), new DateTime(2024, 6, 23, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 6, 23, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2965), new DateTime(2024, 6, 24, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 20, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2969), new DateTime(2024, 6, 25, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 21, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2972), new DateTime(2024, 6, 26, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 22, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2976), new DateTime(2024, 6, 27, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 23, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2980), new DateTime(2024, 6, 28, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 6, 29, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 6, 30, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 26, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2990), new DateTime(2024, 7, 1, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3026), new DateTime(2024, 7, 2, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3030), new DateTime(2024, 7, 3, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 29, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 7, 4, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 30, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 7, 5, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 1, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 7, 6, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 2, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3045), new DateTime(2024, 7, 7, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 3, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 7, 8, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 7, 9, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 5, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3055), new DateTime(2024, 7, 10, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3059), new DateTime(2024, 7, 11, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 7, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3062), new DateTime(2024, 7, 12, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2957), new DateTime(2024, 6, 23, 14, 44, 31, 911, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IconURL", "Name" },
                values: new object[,]
                {
                    { 1, "Guests have the entire home or apartment to themselves", null, "Entire Place" },
                    { 2, "Guests have a private room but share common areas with the host or other guests", null, "Private Room" },
                    { 3, "Guests share a room with the host or other guests", null, "Shared Room" },
                    { 4, "Unusual or unconventional accommodations (treehouses, yurts, etc.)", null, "Unique Stays" },
                    { 5, "Properties with direct access to a beach", null, "Beachfront" },
                    { 6, "Properties with ski-in/ski-out access", null, "Ski-in/Ski-out" },
                    { 7, "Properties that allow pets", null, "Pet-Friendly" },
                    { 8, "High-end properties with premium amenities", null, "Luxury" },
                    { 9, "Rustic cabins for a cozy getaway", null, "Cabin" },
                    { 10, "Modern apartments in urban settings", null, "Apartment" },
                    { 11, "Spacious lofts with open layouts", null, "Loft" },
                    { 12, "Luxurious villas with private pools or jacuzzis", null, "Villa" },
                    { 13, "Historic castles for a unique experience", null, "Castle" },
                    { 14, "Treehouses for a whimsical stay", null, "Treehouse" },
                    { 15, "Houseboats or other boats for a stay on the water", null, "Boat" },
                    { 16, "Unique dome-shaped accommodations", null, "Dome" },
                    { 17, "Small, stylish hotels with personalized service", null, "Boutique Hotel" },
                    { 18, "Properties committed to sustainable practices", null, "Eco-Friendly" },
                    { 19, "Properties with amenities for families with children", null, "Family-Friendly" },
                    { 20, "Properties with features suitable for remote work (fast Wi-Fi, dedicated workspace)", null, "Workcation-Friendly" },
                    { 21, "Description For Category", null, "Apartment" }
                });
        }
    }
}
