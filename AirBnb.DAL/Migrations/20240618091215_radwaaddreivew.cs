using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirBnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class radwaaddreivew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2174), new DateTime(2024, 6, 23, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 6, 24, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 20, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2187), new DateTime(2024, 6, 25, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 21, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 6, 26, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 22, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2198), new DateTime(2024, 6, 27, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 23, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2204), new DateTime(2024, 6, 28, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 24, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 6, 29, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 25, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2216), new DateTime(2024, 6, 30, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2222), new DateTime(2024, 7, 1, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2228), new DateTime(2024, 7, 2, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2234), new DateTime(2024, 7, 3, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 29, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2240), new DateTime(2024, 7, 4, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2245), new DateTime(2024, 7, 5, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 1, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2251), new DateTime(2024, 7, 6, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2257), new DateTime(2024, 7, 7, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 3, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2263), new DateTime(2024, 7, 8, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2268), new DateTime(2024, 7, 9, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 5, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2274), new DateTime(2024, 7, 10, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 6, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2280), new DateTime(2024, 7, 11, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 7, 7, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 7, 12, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2105), new DateTime(2024, 6, 23, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2416), new DateTime(2024, 6, 23, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2422), new DateTime(2024, 6, 24, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 20, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2428), new DateTime(2024, 6, 25, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 21, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2434), new DateTime(2024, 6, 26, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 22, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2440), new DateTime(2024, 6, 27, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 23, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2446), new DateTime(2024, 6, 28, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 24, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2452), new DateTime(2024, 6, 29, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 25, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2458), new DateTime(2024, 6, 30, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2464), new DateTime(2024, 7, 1, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2470), new DateTime(2024, 7, 2, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2476), new DateTime(2024, 7, 3, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 29, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2483), new DateTime(2024, 7, 4, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2489), new DateTime(2024, 7, 5, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 1, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 7, 6, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 2, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 7, 7, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 3, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 7, 8, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 7, 9, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 5, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 7, 10, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 6, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2524), new DateTime(2024, 7, 11, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 7, 7, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2530), new DateTime(2024, 7, 12, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2406), new DateTime(2024, 6, 23, 12, 12, 14, 0, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "PropertyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "PropertyId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "PropertyId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "PropertyId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "PropertyId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "PropertyId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "PropertyId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "PropertyId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "PropertyId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "PropertyId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "PropertyId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "PropertyId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "PropertyId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "PropertyId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "PropertyId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "PropertyId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "PropertyId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "PropertyId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "PropertyId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "PropertyId",
                value: 20);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PropertyId",
                table: "Reviews",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Properties_PropertyId",
                table: "Reviews",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Properties_PropertyId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_PropertyId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 7, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1954), new DateTime(2024, 6, 12, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 8, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1958), new DateTime(2024, 6, 13, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 9, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 6, 14, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 10, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1965), new DateTime(2024, 6, 15, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 11, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 6, 16, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 12, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1971), new DateTime(2024, 6, 17, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 13, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1974), new DateTime(2024, 6, 18, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 14, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1978), new DateTime(2024, 6, 19, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 15, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1981), new DateTime(2024, 6, 20, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 16, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 6, 21, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 17, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 6, 22, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 18, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1991), new DateTime(2024, 6, 23, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 19, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 6, 24, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 20, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1997), new DateTime(2024, 6, 25, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 21, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2000), new DateTime(2024, 6, 26, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 22, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2003), new DateTime(2024, 6, 27, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 23, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2006), new DateTime(2024, 6, 28, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 24, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2010), new DateTime(2024, 6, 29, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 25, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2013), new DateTime(2024, 6, 30, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 26, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2016), new DateTime(2024, 7, 1, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "From", "To" },
                values: new object[] { new DateTime(2024, 6, 7, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1882), new DateTime(2024, 6, 12, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 7, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2060), new DateTime(2024, 6, 12, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 8, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2064), new DateTime(2024, 6, 13, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 9, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2067), new DateTime(2024, 6, 14, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 10, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2070), new DateTime(2024, 6, 15, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 11, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2074), new DateTime(2024, 6, 16, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 12, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2077), new DateTime(2024, 6, 17, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 13, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2080), new DateTime(2024, 6, 18, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 14, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2083), new DateTime(2024, 6, 19, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 15, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2086), new DateTime(2024, 6, 20, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 16, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 6, 21, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 17, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2093), new DateTime(2024, 6, 22, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 18, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2096), new DateTime(2024, 6, 23, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 19, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 6, 24, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 20, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2103), new DateTime(2024, 6, 25, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 21, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 6, 26, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 22, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2109), new DateTime(2024, 6, 27, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 23, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2112), new DateTime(2024, 6, 28, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 24, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2115), new DateTime(2024, 6, 29, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 25, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2119), new DateTime(2024, 6, 30, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 26, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2122), new DateTime(2024, 7, 1, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckInDate", "CheckOutDate" },
                values: new object[] { new DateTime(2024, 6, 7, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 6, 12, 4, 59, 53, 132, DateTimeKind.Local).AddTicks(2058) });
        }
    }
}
