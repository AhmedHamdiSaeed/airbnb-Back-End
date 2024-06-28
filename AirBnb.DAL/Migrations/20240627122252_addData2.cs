using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirBnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Id", "Adress", "Beds", "CategoryId", "CheckIn", "CheckOut", "CityId", "Description", "DisplayedImage", "Name", "NumberOfBathrooms", "NumberOfBedrooms", "NumberOfGuest", "Pets", "Status", "TakePhotos", "UserId" },
                values: new object[,]
                {
                    { 1, "Cairo", 8, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 1, "No Description", "https://example.com/image1.jpg", "Apartment", 1, 4, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 2, "Alexandria", 5, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 2, "Sea view with modern amenities", "https://example.com/image1.jpg", "Beach House", 2, 3, 10, true, 2, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 3, "Aswan", 3, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 3, "Cozy cabin in the mountains", "https://example.com/image1.jpg", "Mountain Cabin", 1, 2, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 4, "Sharm El-Sheikh", 10, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 4, "Luxurious villa with a private pool", "https://example.com/image1.jpg", "Luxury Villa", 4, 5, 10, true, 3, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 5, "Giza", 4, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 5, "Modern condo in the city center", "https://example.com/image1.jpg", "Downtown Condo", 2, 2, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 6, "Luxor", 7, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 6, "Spacious farmhouse with a garden", "https://example.com/image1.jpg", "Farmhouse", 3, 4, 10, true, 2, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 7, "Cairo", 6, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 1, "Penthouse with panoramic views", "https://example.com/image1.jpg", "Penthouse", 3, 3, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 8, "Helwan", 5, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 8, "Family home in a quiet suburb", "https://example.com/image1.jpg", "Suburban Home", 2, 3, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 9, "Alexandria", 1, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 2, "Compact studio in a bustling area", "https://example.com/image1.jpg", "Studio Apartment", 1, 1, 10, true, 3, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 10, "Minya", 3, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 10, "Charming cottage in the countryside", "https://example.com/image1.jpg", "Country Cottage", 1, 2, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 11, "Fayoum", 5, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 11, "Peaceful house by the lake", "https://example.com/image1.jpg", "Lake House", 2, 3, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 12, "Cairo", 2, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 1, "Stylish loft in an urban setting", "https://example.com/image1.jpg", "Urban Loft", 1, 2, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 13, "Suez", 4, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 13, "Modern townhouse with a garage", "https://example.com/image1.jpg", "Townhouse", 2, 3, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 14, "Alexandria", 7, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 2, "Home with historical significance", "https://example.com/image1.jpg", "Historical Home", 3, 4, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 15, "Siwa", 3, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 15, "Retreat in the quiet of the desert", "https://example.com/image1.jpg", "Desert Retreat", 1, 2, 10, true, 2, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 16, "Dahab", 4, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 16, "Single-story bungalow with a yard", "https://example.com/image1.jpg", "Bungalow", 1, 3, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 17, "Cairo", 1, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 1, "Modern flat in a residential complex", "https://example.com/image1.jpg", "Modern Flat", 1, 1, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 18, "Port Said", 5, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 18, "Eco-friendly house with solar panels", "https://example.com/image1.jpg", "Eco-Friendly House", 2, 3, 10, true, 3, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 19, "Hurghada", 9, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 19, "Villa with a view of the sea", "https://example.com/image1.jpg", "Seaside Villa", 4, 5, 10, true, 0, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 20, "Sinai", 3, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 20, "Cabin with a rustic charm", "https://example.com/image1.jpg", "Rustic Cabin", 1, 2, 10, true, 2, false, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" }
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
                    { 1, new DateTime(2024, 6, 27, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(2990), true, 20m, 1, new DateTime(2024, 7, 2, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(2992) },
                    { 2, new DateTime(2024, 6, 28, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(2995), true, 25m, 2, new DateTime(2024, 7, 3, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(2996) },
                    { 3, new DateTime(2024, 6, 29, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(2999), false, 30m, 3, new DateTime(2024, 7, 4, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3000) },
                    { 4, new DateTime(2024, 6, 30, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3003), true, 35m, 4, new DateTime(2024, 7, 5, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3005) },
                    { 5, new DateTime(2024, 7, 1, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3008), true, 40m, 5, new DateTime(2024, 7, 6, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3010) },
                    { 6, new DateTime(2024, 7, 2, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3012), false, 45m, 6, new DateTime(2024, 7, 7, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3014) },
                    { 7, new DateTime(2024, 7, 3, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3016), true, 50m, 7, new DateTime(2024, 7, 8, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3018) },
                    { 8, new DateTime(2024, 7, 4, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3021), true, 55m, 8, new DateTime(2024, 7, 9, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3023) },
                    { 9, new DateTime(2024, 7, 5, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3025), false, 60m, 9, new DateTime(2024, 7, 10, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3027) },
                    { 10, new DateTime(2024, 7, 6, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3029), true, 65m, 10, new DateTime(2024, 7, 11, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3031) },
                    { 11, new DateTime(2024, 7, 7, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3034), true, 70m, 11, new DateTime(2024, 7, 12, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3036) },
                    { 12, new DateTime(2024, 7, 8, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3039), false, 75m, 12, new DateTime(2024, 7, 13, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3040) },
                    { 13, new DateTime(2024, 7, 9, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3043), true, 80m, 13, new DateTime(2024, 7, 14, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3045) },
                    { 14, new DateTime(2024, 7, 10, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3047), true, 85m, 14, new DateTime(2024, 7, 15, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3049) },
                    { 15, new DateTime(2024, 7, 11, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3052), false, 90m, 15, new DateTime(2024, 7, 16, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3054) },
                    { 16, new DateTime(2024, 7, 12, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3056), true, 95m, 16, new DateTime(2024, 7, 17, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3058) },
                    { 17, new DateTime(2024, 7, 13, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3060), true, 100m, 17, new DateTime(2024, 7, 18, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3062) },
                    { 18, new DateTime(2024, 7, 14, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3065), false, 105m, 18, new DateTime(2024, 7, 19, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3066) },
                    { 19, new DateTime(2024, 7, 15, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3069), true, 110m, 19, new DateTime(2024, 7, 20, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3071) },
                    { 20, new DateTime(2024, 7, 16, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3074), true, 115m, 20, new DateTime(2024, 7, 21, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3075) },
                    { 21, new DateTime(2024, 6, 27, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(2883), true, 20m, 1, new DateTime(2024, 7, 2, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(2972) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingStatus", "CheckInDate", "CheckOutDate", "ClientSecret", "PaymentIntentId", "PropertyId", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 6, 27, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3148), new DateTime(2024, 7, 2, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3150), null, null, 1, 100, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 2, 2, new DateTime(2024, 6, 28, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 7, 3, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3155), null, null, 2, 150, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 3, 2, new DateTime(2024, 6, 29, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3158), new DateTime(2024, 7, 4, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3159), null, null, 3, 200, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 4, 0, new DateTime(2024, 6, 30, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 7, 5, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3164), null, null, 4, 250, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 5, 2, new DateTime(2024, 7, 1, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 7, 6, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3168), null, null, 5, 300, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 6, 2, new DateTime(2024, 7, 2, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3170), new DateTime(2024, 7, 7, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3172), null, null, 6, 350, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 7, 0, new DateTime(2024, 7, 3, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 7, 8, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3176), null, null, 7, 400, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 8, 2, new DateTime(2024, 7, 4, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 7, 9, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3180), null, null, 8, 450, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 9, 2, new DateTime(2024, 7, 5, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3183), new DateTime(2024, 7, 10, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3185), null, null, 9, 500, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 10, 0, new DateTime(2024, 7, 6, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3187), new DateTime(2024, 7, 11, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3189), null, null, 10, 550, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 11, 2, new DateTime(2024, 7, 7, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3191), new DateTime(2024, 7, 12, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3193), null, null, 11, 600, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 12, 2, new DateTime(2024, 7, 8, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3195), new DateTime(2024, 7, 13, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3197), null, null, 12, 650, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 13, 0, new DateTime(2024, 7, 9, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 7, 14, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3201), null, null, 13, 700, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 14, 2, new DateTime(2024, 7, 10, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3204), new DateTime(2024, 7, 15, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3206), null, null, 14, 750, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 15, 2, new DateTime(2024, 7, 11, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3208), new DateTime(2024, 7, 16, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3210), null, null, 15, 800, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 16, 0, new DateTime(2024, 7, 12, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3212), new DateTime(2024, 7, 17, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3214), null, null, 16, 850, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 17, 2, new DateTime(2024, 7, 13, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3217), new DateTime(2024, 7, 18, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3218), null, null, 17, 900, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 18, 2, new DateTime(2024, 7, 14, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3221), new DateTime(2024, 7, 19, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3222), null, null, 18, 950, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 19, 0, new DateTime(2024, 7, 15, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3225), new DateTime(2024, 7, 20, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3227), null, null, 19, 1000, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 20, 2, new DateTime(2024, 7, 16, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 7, 21, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3232), null, null, 20, 1050, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 21, 0, new DateTime(2024, 6, 27, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 7, 2, 15, 22, 52, 48, DateTimeKind.Local).AddTicks(3145), null, null, 1, 100, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" }
                });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "Id", "ImageUrl", "PropertyId" },
                values: new object[,]
                {
                    { 1, "https://example.com/image1.jpg", 1 },
                    { 2, "https://example.com/image2.jpg", 1 },
                    { 3, "https://example.com/image3.jpg", 1 },
                    { 4, "https://example.com/image4.jpg", 1 },
                    { 5, "https://example.com/image5.jpg", 2 },
                    { 6, "https://example.com/image6.jpg", 2 },
                    { 7, "https://example.com/image7.jpg", 2 },
                    { 8, "https://example.com/image8.jpg", 2 },
                    { 9, "https://example.com/image9.jpg", 3 },
                    { 10, "https://example.com/image10.jpg", 3 },
                    { 11, "https://example.com/image11.jpg", 3 },
                    { 12, "https://example.com/image12.jpg", 3 },
                    { 13, "https://example.com/image13.jpg", 4 },
                    { 14, "https://example.com/image14.jpg", 4 },
                    { 15, "https://example.com/image15.jpg", 4 },
                    { 16, "https://example.com/image16.jpg", 4 },
                    { 17, "https://example.com/image17.jpg", 5 },
                    { 18, "https://example.com/image18.jpg", 5 },
                    { 19, "https://example.com/image19.jpg", 5 },
                    { 20, "https://example.com/image20.jpg", 5 },
                    { 21, "https://example.com/image21.jpg", 6 },
                    { 22, "https://example.com/image22.jpg", 6 },
                    { 23, "https://example.com/image23.jpg", 6 },
                    { 24, "https://example.com/image24.jpg", 6 },
                    { 25, "https://example.com/image25.jpg", 7 },
                    { 26, "https://example.com/image26.jpg", 7 },
                    { 27, "https://example.com/image27.jpg", 7 },
                    { 28, "https://example.com/image28.jpg", 7 },
                    { 29, "https://example.com/image29.jpg", 8 },
                    { 30, "https://example.com/image30.jpg", 8 },
                    { 31, "https://example.com/image31.jpg", 8 },
                    { 32, "https://example.com/image32.jpg", 8 },
                    { 33, "https://example.com/image33.jpg", 9 },
                    { 34, "https://example.com/image34.jpg", 9 },
                    { 35, "https://example.com/image35.jpg", 9 },
                    { 36, "https://example.com/image36.jpg", 9 },
                    { 37, "https://example.com/image37.jpg", 10 },
                    { 38, "https://example.com/image38.jpg", 10 },
                    { 39, "https://example.com/image39.jpg", 10 },
                    { 40, "https://example.com/image40.jpg", 10 },
                    { 41, "https://example.com/image41.jpg", 11 },
                    { 42, "https://example.com/image42.jpg", 11 },
                    { 43, "https://example.com/image43.jpg", 11 },
                    { 44, "https://example.com/image44.jpg", 11 },
                    { 45, "https://example.com/image45.jpg", 12 },
                    { 46, "https://example.com/image46.jpg", 12 },
                    { 47, "https://example.com/image47.jpg", 12 },
                    { 48, "https://example.com/image48.jpg", 12 },
                    { 49, "https://example.com/image49.jpg", 13 },
                    { 50, "https://example.com/image50.jpg", 13 },
                    { 51, "https://example.com/image51.jpg", 13 },
                    { 52, "https://example.com/image52.jpg", 13 },
                    { 53, "https://example.com/image53.jpg", 14 },
                    { 54, "https://example.com/image54.jpg", 14 },
                    { 55, "https://example.com/image55.jpg", 14 },
                    { 56, "https://example.com/image56.jpg", 14 },
                    { 57, "https://example.com/image57.jpg", 15 },
                    { 58, "https://example.com/image58.jpg", 15 },
                    { 59, "https://example.com/image59.jpg", 15 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookingId", "Comment", "PropertyId", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Good Comment", 8, 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 2, 2, "Nice place", 1, 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 3, 3, "Average experience", 4, 3, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 4, 4, "Not as expected", 8, 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 5, 5, "Excellent service", 2, 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 6, 6, "Good value for money", 7, 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 7, 7, "Decent stay", 3, 3, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 8, 8, "Terrible experience", 8, 1, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 9, 9, "Highly recommend", 7, 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 10, 10, "Very comfortable", 6, 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 11, 11, "Could be better", 5, 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 12, 12, "Loved the place", 2, 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 13, 13, "It was okay", 4, 3, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 14, 14, "Pretty good", 4, 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 15, 15, "Needs improvement", 3, 2, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 16, 16, "Fantastic stay", 2, 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 17, 17, "Very disappointing", 4, 1, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 18, 18, "Good location", 3, 4, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 19, 19, "Not bad", 2, 3, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" },
                    { 20, 20, "Amazing experience", 2, 5, "53f9998c-e5c9-4bd5-8db6-eefc68f7fb4f" }
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
