using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirBnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Guests have the entire home or apartment to themselves", "Entire Place" },
                    { 2, "Guests have a private room but share common areas with the host or other guests", "Private Room" },
                    { 3, "Guests share a room with the host or other guests", "Shared Room" },
                    { 4, "Unusual or unconventional accommodations (treehouses, yurts, etc.)", "Unique Stays" },
                    { 5, "Properties with direct access to a beach", "Beachfront" },
                    { 6, "Properties with ski-in/ski-out access", "Ski-in/Ski-out" },
                    { 7, "Properties that allow pets", "Pet-Friendly" },
                    { 8, "High-end properties with premium amenities", "Luxury" },
                    { 9, "Rustic cabins for a cozy getaway", "Cabin" },
                    { 10, "Modern apartments in urban settings", "Apartment" },
                    { 11, "Spacious lofts with open layouts", "Loft" },
                    { 12, "Luxurious villas with private pools or jacuzzis", "Villa" },
                    { 13, "Historic castles for a unique experience", "Castle" },
                    { 14, "Treehouses for a whimsical stay", "Treehouse" },
                    { 15, "Houseboats or other boats for a stay on the water", "Boat" },
                    { 16, "Unique dome-shaped accommodations", "Dome" },
                    { 17, "Small, stylish hotels with personalized service", "Boutique Hotel" },
                    { 18, "Properties committed to sustainable practices", "Eco-Friendly" },
                    { 19, "Properties with amenities for families with children", "Family-Friendly" },
                    { 20, "Properties with features suitable for remote work (fast Wi-Fi, dedicated workspace)", "Workcation-Friendly" },
                    { 21, "Description For Category", "Apartment" }
                });

            migrationBuilder.InsertData(
                table: "Countires",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Egypt" },
                    { 2, "France" },
                    { 3, "Italy" },
                    { 4, "Algeria" },
                    { 5, "Oman" },
                    { 6, "Yemen" },
                    { 7, "Germany" },
                    { 8, "Qatar" },
                    { 9, "Palestine" },
                    { 10, "Morocco" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Cairo" },
                    { 2, 2, "Tokyo" },
                    { 3, 3, "London" },
                    { 4, 4, "Paris" },
                    { 5, 5, "New York City" },
                    { 6, 6, "Berlin" },
                    { 7, 7, "Rome" },
                    { 8, 8, "Madrid" },
                    { 9, 9, "Singapore" },
                    { 10, 10, "Seoul" },
                    { 11, 1, "Sydney" },
                    { 12, 2, "Buenos Aires" },
                    { 13, 3, "Toronto" },
                    { 14, 4, "Moscow" },
                    { 15, 5, "Dubai" },
                    { 16, 6, "São Paulo" },
                    { 17, 7, "Mexico City" },
                    { 18, 8, "Los Angeles" },
                    { 19, 9, "Mumbai" },
                    { 20, 10, "Istanbul" },
                    { 21, 1, "Beijing" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Adress", "Beds", "CategoryId", "CityId", "Description", "Name", "NumberOfBathrooms", "NumberOfBedrooms", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, "Cairo", 8, 1, 1, "No Description", "Apartment", 1, 4, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 2, "Alexandria", 5, 2, 2, "Sea view with modern amenities", "Beach House", 2, 3, 1, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 3, "Aswan", 3, 3, 3, "Cozy cabin in the mountains", "Mountain Cabin", 1, 2, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 4, "Sharm El-Sheikh", 10, 4, 4, "Luxurious villa with a private pool", "Luxury Villa", 4, 5, 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 5, "Giza", 4, 5, 5, "Modern condo in the city center", "Downtown Condo", 2, 2, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 6, "Luxor", 7, 6, 6, "Spacious farmhouse with a garden", "Farmhouse", 3, 4, 1, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 7, "Cairo", 6, 7, 1, "Penthouse with panoramic views", "Penthouse", 3, 3, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 8, "Helwan", 5, 8, 8, "Family home in a quiet suburb", "Suburban Home", 2, 3, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 9, "Alexandria", 1, 9, 2, "Compact studio in a bustling area", "Studio Apartment", 1, 1, 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 10, "Minya", 3, 10, 10, "Charming cottage in the countryside", "Country Cottage", 1, 2, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 11, "Fayoum", 5, 11, 11, "Peaceful house by the lake", "Lake House", 2, 3, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 12, "Cairo", 2, 12, 1, "Stylish loft in an urban setting", "Urban Loft", 1, 2, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 13, "Suez", 4, 13, 13, "Modern townhouse with a garage", "Townhouse", 2, 3, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 14, "Alexandria", 7, 14, 2, "Home with historical significance", "Historical Home", 3, 4, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 15, "Siwa", 3, 15, 15, "Retreat in the quiet of the desert", "Desert Retreat", 1, 2, 1, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 16, "Dahab", 4, 16, 16, "Single-story bungalow with a yard", "Bungalow", 1, 3, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 17, "Cairo", 1, 17, 1, "Modern flat in a residential complex", "Modern Flat", 1, 1, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 18, "Port Said", 5, 18, 18, "Eco-friendly house with solar panels", "Eco-Friendly House", 2, 3, 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 19, "Hurghada", 9, 19, 19, "Villa with a view of the sea", "Seaside Villa", 4, 5, 0, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 20, "Sinai", 3, 20, 20, "Cabin with a rustic charm", "Rustic Cabin", 1, 2, 1, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" }
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Description", "Name", "propertyId" },
                values: new object[,]
                {
                    { 1, "Large outdoor pool", "Swimming Pool", 1 },
                    { 2, "Fully equipped fitness center", "Gym", 2 },
                    { 3, "High-speed wireless internet", "WiFi", 3 },
                    { 4, "Secure parking area", "Parking", 4 },
                    { 5, "Central air conditioning system", "Air Conditioning", 5 },
                    { 6, "Central heating system", "Heating", 6 },
                    { 7, "Private balcony with a view", "Balcony", 7 },
                    { 8, "Allows pets", "Pet Friendly", 8 },
                    { 9, "Full-service spa", "Spa", 9 },
                    { 10, "Fully equipped kitchen", "Kitchen", 10 },
                    { 11, "In-unit washer and dryer", "Laundry", 11 },
                    { 12, "Elevator access", "Elevator", 12 },
                    { 13, "Wood-burning fireplace", "Fireplace", 13 },
                    { 14, "Outdoor BBQ area", "BBQ Area", 14 },
                    { 15, "Private hot tub", "Hot Tub", 15 },
                    { 16, "Private sauna", "Sauna", 16 },
                    { 17, "Private garden area", "Garden", 17 },
                    { 18, "Room with games and entertainment", "Game Room", 18 },
                    { 19, "24-hour security", "Security", 19 },
                    { 20, "Private home theater", "Theater Room", 20 },
                    { 21, "No Description", "Egypt", 1 }
                });

            migrationBuilder.InsertData(
                table: "AppointmentsAvailable",
                columns: new[] { "Id", "From", "IsAvailable", "PricePerNight", "PropertyId", "To" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 31, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9373), true, 20m, 1, new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9375) },
                    { 2, new DateTime(2024, 6, 1, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9378), true, 25m, 2, new DateTime(2024, 6, 6, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9379) },
                    { 3, new DateTime(2024, 6, 2, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9381), false, 30m, 3, new DateTime(2024, 6, 7, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9382) },
                    { 4, new DateTime(2024, 6, 3, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9384), true, 35m, 4, new DateTime(2024, 6, 8, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9386) },
                    { 5, new DateTime(2024, 6, 4, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9388), true, 40m, 5, new DateTime(2024, 6, 9, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9389) },
                    { 6, new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9391), false, 45m, 6, new DateTime(2024, 6, 10, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9392) },
                    { 7, new DateTime(2024, 6, 6, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9394), true, 50m, 7, new DateTime(2024, 6, 11, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9395) },
                    { 8, new DateTime(2024, 6, 7, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9397), true, 55m, 8, new DateTime(2024, 6, 12, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9398) },
                    { 9, new DateTime(2024, 6, 8, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9400), false, 60m, 9, new DateTime(2024, 6, 13, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9401) },
                    { 10, new DateTime(2024, 6, 9, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9403), true, 65m, 10, new DateTime(2024, 6, 14, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9404) },
                    { 11, new DateTime(2024, 6, 10, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9406), true, 70m, 11, new DateTime(2024, 6, 15, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9407) },
                    { 12, new DateTime(2024, 6, 11, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9409), false, 75m, 12, new DateTime(2024, 6, 16, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9410) },
                    { 13, new DateTime(2024, 6, 12, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9412), true, 80m, 13, new DateTime(2024, 6, 17, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9414) },
                    { 14, new DateTime(2024, 6, 13, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9416), true, 85m, 14, new DateTime(2024, 6, 18, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9417) },
                    { 15, new DateTime(2024, 6, 14, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9419), false, 90m, 15, new DateTime(2024, 6, 19, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9420) },
                    { 16, new DateTime(2024, 6, 15, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9422), true, 95m, 16, new DateTime(2024, 6, 20, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9423) },
                    { 17, new DateTime(2024, 6, 16, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9425), true, 100m, 17, new DateTime(2024, 6, 21, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9426) },
                    { 18, new DateTime(2024, 6, 17, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9428), false, 105m, 18, new DateTime(2024, 6, 22, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9429) },
                    { 19, new DateTime(2024, 6, 18, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9431), true, 110m, 19, new DateTime(2024, 6, 23, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9432) },
                    { 20, new DateTime(2024, 6, 19, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9434), true, 115m, 20, new DateTime(2024, 6, 24, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9435) },
                    { 21, new DateTime(2024, 5, 31, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9314), true, 20m, 1, new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9366) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingStatus", "CheckInDate", "CheckOutDate", "PropertyId", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 5, 31, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9475), new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9476), 1, 100, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 2, 1, new DateTime(2024, 6, 1, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9478), new DateTime(2024, 6, 6, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9479), 2, 150, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 3, 1, new DateTime(2024, 6, 2, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 6, 7, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9483), 3, 200, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 4, 0, new DateTime(2024, 6, 3, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 6, 8, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9486), 4, 250, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 5, 1, new DateTime(2024, 6, 4, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 6, 9, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9489), 5, 300, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 6, 1, new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 6, 10, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9492), 6, 350, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 7, 0, new DateTime(2024, 6, 6, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9494), new DateTime(2024, 6, 11, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9495), 7, 400, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 8, 1, new DateTime(2024, 6, 7, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 6, 12, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9498), 8, 450, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 9, 1, new DateTime(2024, 6, 8, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 6, 13, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9502), 9, 500, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 10, 0, new DateTime(2024, 6, 9, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9504), new DateTime(2024, 6, 14, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9505), 10, 550, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 11, 1, new DateTime(2024, 6, 10, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9507), new DateTime(2024, 6, 15, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9508), 11, 600, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 12, 1, new DateTime(2024, 6, 11, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 6, 16, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9511), 12, 650, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 13, 0, new DateTime(2024, 6, 12, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 6, 17, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9514), 13, 700, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 14, 1, new DateTime(2024, 6, 13, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 6, 18, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9517), 14, 750, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 15, 1, new DateTime(2024, 6, 14, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9519), new DateTime(2024, 6, 19, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9520), 15, 800, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 16, 0, new DateTime(2024, 6, 15, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 6, 20, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9523), 16, 850, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 17, 1, new DateTime(2024, 6, 16, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9525), new DateTime(2024, 6, 21, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9527), 17, 900, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 18, 1, new DateTime(2024, 6, 17, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9528), new DateTime(2024, 6, 22, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9530), 18, 950, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 19, 0, new DateTime(2024, 6, 18, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9531), new DateTime(2024, 6, 23, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9533), 19, 1000, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 20, 1, new DateTime(2024, 6, 19, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9535), new DateTime(2024, 6, 24, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9536), 20, 1050, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 21, 0, new DateTime(2024, 5, 31, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9469), new DateTime(2024, 6, 5, 11, 26, 58, 891, DateTimeKind.Local).AddTicks(9472), 1, 100, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" }
                });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "Id", "ImageUrl", "IsMainImage", "PropertyId" },
                values: new object[,]
                {
                    { 1, "https://example.com/image1.jpg", true, 1 },
                    { 2, "https://example.com/image2.jpg", false, 1 },
                    { 3, "https://example.com/image3.jpg", false, 1 },
                    { 4, "https://example.com/image4.jpg", false, 1 },
                    { 5, "https://example.com/image5.jpg", true, 2 },
                    { 6, "https://example.com/image6.jpg", false, 2 },
                    { 7, "https://example.com/image7.jpg", false, 2 },
                    { 8, "https://example.com/image8.jpg", false, 2 },
                    { 9, "https://example.com/image9.jpg", true, 3 },
                    { 10, "https://example.com/image10.jpg", false, 3 },
                    { 11, "https://example.com/image11.jpg", false, 3 },
                    { 12, "https://example.com/image12.jpg", false, 3 },
                    { 13, "https://example.com/image13.jpg", true, 4 },
                    { 14, "https://example.com/image14.jpg", false, 4 },
                    { 15, "https://example.com/image15.jpg", false, 4 },
                    { 16, "https://example.com/image16.jpg", false, 4 },
                    { 17, "https://example.com/image17.jpg", true, 5 },
                    { 18, "https://example.com/image18.jpg", false, 5 },
                    { 19, "https://example.com/image19.jpg", false, 5 },
                    { 20, "https://example.com/image20.jpg", false, 5 },
                    { 21, "https://example.com/image21.jpg", true, 6 },
                    { 22, "https://example.com/image22.jpg", false, 6 },
                    { 23, "https://example.com/image23.jpg", false, 6 },
                    { 24, "https://example.com/image24.jpg", false, 6 },
                    { 25, "https://example.com/image25.jpg", true, 7 },
                    { 26, "https://example.com/image26.jpg", false, 7 },
                    { 27, "https://example.com/image27.jpg", false, 7 },
                    { 28, "https://example.com/image28.jpg", false, 7 },
                    { 29, "https://example.com/image29.jpg", true, 8 },
                    { 30, "https://example.com/image30.jpg", false, 8 },
                    { 31, "https://example.com/image31.jpg", false, 8 },
                    { 32, "https://example.com/image32.jpg", false, 8 },
                    { 33, "https://example.com/image33.jpg", true, 9 },
                    { 34, "https://example.com/image34.jpg", false, 9 },
                    { 35, "https://example.com/image35.jpg", false, 9 },
                    { 36, "https://example.com/image36.jpg", false, 9 },
                    { 37, "https://example.com/image37.jpg", true, 10 },
                    { 38, "https://example.com/image38.jpg", false, 10 },
                    { 39, "https://example.com/image39.jpg", false, 10 },
                    { 40, "https://example.com/image40.jpg", false, 10 },
                    { 41, "https://example.com/image41.jpg", true, 11 },
                    { 42, "https://example.com/image42.jpg", false, 11 },
                    { 43, "https://example.com/image43.jpg", false, 11 },
                    { 44, "https://example.com/image44.jpg", false, 11 },
                    { 45, "https://example.com/image45.jpg", true, 12 },
                    { 46, "https://example.com/image46.jpg", false, 12 },
                    { 47, "https://example.com/image47.jpg", false, 12 },
                    { 48, "https://example.com/image48.jpg", false, 12 },
                    { 49, "https://example.com/image49.jpg", true, 13 },
                    { 50, "https://example.com/image50.jpg", false, 13 },
                    { 51, "https://example.com/image51.jpg", false, 13 },
                    { 52, "https://example.com/image52.jpg", false, 13 },
                    { 53, "https://example.com/image53.jpg", true, 14 },
                    { 54, "https://example.com/image54.jpg", false, 14 },
                    { 55, "https://example.com/image55.jpg", false, 14 },
                    { 56, "https://example.com/image56.jpg", false, 14 },
                    { 57, "https://example.com/image57.jpg", true, 15 },
                    { 58, "https://example.com/image58.jpg", false, 15 },
                    { 59, "https://example.com/image59.jpg", false, 15 }
                });

            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "CheckIn", "CheckOut", "NumberOfGuest", "Pets", "PropertyId", "TakePhotos" },
                values: new object[,]
                {
                    { 1, new TimeOnly(16, 0, 0), new TimeOnly(9, 0, 0), 2, true, 1, true },
                    { 2, new TimeOnly(15, 0, 0), new TimeOnly(10, 0, 0), 3, false, 2, true },
                    { 3, new TimeOnly(17, 0, 0), new TimeOnly(11, 0, 0), 4, true, 3, false },
                    { 4, new TimeOnly(14, 0, 0), new TimeOnly(12, 0, 0), 5, false, 4, true },
                    { 5, new TimeOnly(18, 0, 0), new TimeOnly(9, 30, 0), 2, true, 5, true },
                    { 6, new TimeOnly(13, 0, 0), new TimeOnly(10, 30, 0), 3, true, 6, false },
                    { 7, new TimeOnly(16, 30, 0), new TimeOnly(8, 0, 0), 1, false, 7, true },
                    { 8, new TimeOnly(15, 30, 0), new TimeOnly(11, 0, 0), 2, true, 8, true },
                    { 9, new TimeOnly(14, 30, 0), new TimeOnly(12, 30, 0), 4, false, 9, false },
                    { 10, new TimeOnly(17, 30, 0), new TimeOnly(10, 0, 0), 5, true, 10, true },
                    { 11, new TimeOnly(18, 0, 0), new TimeOnly(9, 0, 0), 3, false, 11, true },
                    { 12, new TimeOnly(15, 0, 0), new TimeOnly(8, 30, 0), 1, true, 12, false },
                    { 13, new TimeOnly(16, 30, 0), new TimeOnly(11, 30, 0), 2, true, 13, true },
                    { 14, new TimeOnly(17, 0, 0), new TimeOnly(12, 0, 0), 4, false, 14, true },
                    { 15, new TimeOnly(14, 0, 0), new TimeOnly(10, 0, 0), 5, true, 15, false },
                    { 16, new TimeOnly(13, 0, 0), new TimeOnly(9, 30, 0), 2, false, 16, true },
                    { 17, new TimeOnly(16, 0, 0), new TimeOnly(8, 0, 0), 3, true, 17, true },
                    { 18, new TimeOnly(15, 0, 0), new TimeOnly(11, 0, 0), 1, true, 18, false },
                    { 19, new TimeOnly(17, 0, 0), new TimeOnly(9, 30, 0), 2, false, 19, true },
                    { 20, new TimeOnly(14, 0, 0), new TimeOnly(10, 0, 0), 4, true, 20, true },
                    { 21, new TimeOnly(16, 0, 0), new TimeOnly(9, 0, 0), 2, true, 1, true }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookingId", "Comment", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Good Comment", 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 2, 2, "Nice place", 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 3, 3, "Average experience", 3, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 4, 4, "Not as expected", 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 5, 5, "Excellent service", 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 6, 6, "Good value for money", 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 7, 7, "Decent stay", 3, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 8, 8, "Terrible experience", 1, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 9, 9, "Highly recommend", 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 10, 10, "Very comfortable", 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 11, 11, "Could be better", 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 12, 12, "Loved the place", 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 13, 13, "It was okay", 3, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 14, 14, "Pretty good", 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 15, 15, "Needs improvement", 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 16, 16, "Fantastic stay", 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 17, 17, "Very disappointing", 1, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 18, 18, "Good location", 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 19, 19, "Not bad", 3, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 20, 20, "Amazing experience", 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AppointmentsAvailable",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 20);

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
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countires",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
