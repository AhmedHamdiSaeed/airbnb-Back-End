using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirBnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AmenityAndAvailabilityValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerNight",
                table: "AppointmentsAvailable",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Amenities",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 1, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2049), new DateTime(2024, 6, 6, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 2, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 6, 7, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 3, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2060), new DateTime(2024, 6, 8, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 6, 9, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2072), new DateTime(2024, 6, 10, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 6, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2077), new DateTime(2024, 6, 11, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2083), new DateTime(2024, 6, 12, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 8, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 6, 13, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2141), new DateTime(2024, 6, 14, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 6, 15, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2154), new DateTime(2024, 6, 16, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 12, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 6, 17, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 6, 18, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 14, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2171), new DateTime(2024, 6, 19, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 6, 20, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 16, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2183), new DateTime(2024, 6, 21, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 17, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2189), new DateTime(2024, 6, 22, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2194), new DateTime(2024, 6, 23, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2201), new DateTime(2024, 6, 24, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 6, 25, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 1, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(1991), new DateTime(2024, 6, 6, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 1, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2278), new DateTime(2024, 6, 6, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 2, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2283), new DateTime(2024, 6, 7, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 3, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2290), new DateTime(2024, 6, 8, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 6, 9, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2302), new DateTime(2024, 6, 10, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 6, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2307), new DateTime(2024, 6, 11, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 6, 12, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 8, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2319), new DateTime(2024, 6, 13, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 6, 14, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 6, 15, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 6, 16, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 12, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2342), new DateTime(2024, 6, 17, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2348), new DateTime(2024, 6, 18, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 14, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2353), new DateTime(2024, 6, 19, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 6, 20, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 16, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2364), new DateTime(2024, 6, 21, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 17, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 6, 22, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2505), new DateTime(2024, 6, 23, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2511), new DateTime(2024, 6, 24, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 20, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 6, 25, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 1, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 6, 6, 17, 53, 30, 487, DateTimeKind.Local).AddTicks(2272) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerNight",
                table: "AppointmentsAvailable",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 1, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 6, 6, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 2, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9381), new DateTime(2024, 6, 7, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 3, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9384), new DateTime(2024, 6, 8, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 4, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9388), new DateTime(2024, 6, 9, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 6, 10, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9394), new DateTime(2024, 6, 11, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 7, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 6, 12, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 8, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 6, 13, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 6, 14, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 10, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9406), new DateTime(2024, 6, 15, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 11, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9409), new DateTime(2024, 6, 16, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 12, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9412), new DateTime(2024, 6, 17, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9416), new DateTime(2024, 6, 18, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 14, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9419), new DateTime(2024, 6, 19, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 6, 20, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 16, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9425), new DateTime(2024, 6, 21, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 17, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 6, 22, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9431), new DateTime(2024, 6, 23, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9434), new DateTime(2024, 6, 24, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9475), new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 1, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9478), new DateTime(2024, 6, 6, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 2, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 6, 7, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 3, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 6, 8, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 4, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 6, 9, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 6, 10, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 6, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9494), new DateTime(2024, 6, 11, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 7, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 6, 12, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 8, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 6, 13, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9504), new DateTime(2024, 6, 14, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 10, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9507), new DateTime(2024, 6, 15, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 11, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 6, 16, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 12, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 6, 17, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 6, 18, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 14, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9519), new DateTime(2024, 6, 19, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 6, 20, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 16, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9525), new DateTime(2024, 6, 21, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 17, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9528), new DateTime(2024, 6, 22, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9531), new DateTime(2024, 6, 23, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9535), new DateTime(2024, 6, 24, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9469), new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9472) });
        }
    }
}
