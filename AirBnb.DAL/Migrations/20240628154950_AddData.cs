using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirBnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IconURL", "Name" },
                values: new object[,]
                {
                    { 1, "Guests have the entire home or apartment to themselves", "https://localhost:7116/Assets/Category/2.jpg", "Entire Place" },
                    { 2, "Guests have a private room but share common areas with the host or other guests", "https://localhost:7116/Assets/Category/3.jpg", "Private Room" },
                    { 3, "Guests share a room with the host or other guests", "https://localhost:7116/Assets/Category/4.jpg", "Shared Room" },
                    { 4, "Unusual or unconventional accommodations (treehouses, yurts, etc.)", "https://localhost:7116/Assets/Category/5.jpg", "Unique Stays" },
                    { 5, "Properties with direct access to a beach", "https://localhost:7116/Assets/Category/6.jpg", "Beachfront" },
                    { 6, "Properties with ski-in/ski-out access", "https://localhost:7116/Assets/Category/7.jpg", "Ski-in/Ski-out" },
                    { 7, "Properties that allow pets", "https://localhost:7116/Assets/Category/8.jpg", "Pet-Friendly" },
                    { 8, "High-end properties with premium amenities", "https://localhost:7116/Assets/Category/9.jpg", "Luxury" },
                    { 9, "Rustic cabins for a cozy getaway", "https://localhost:7116/Assets/Category/10.jpg", "Cabin" },
                    { 10, "Modern apartments in urban settings", "https://localhost:7116/Assets/Category/11.jpg", "Apartment" },
                    { 11, "Spacious lofts with open layouts", "https://localhost:7116/Assets/Category/12.jpg", "Loft" },
                    { 12, "Luxurious villas with private pools or jacuzzis", "https://localhost:7116/Assets/Category/13.jpg", "Villa" },
                    { 13, "Historic castles for a unique experience", "https://localhost:7116/Assets/Category/14.jpg", "Castle" },
                    { 14, "Treehouses for a whimsical stay", "https://localhost:7116/Assets/Category/15.jpg", "Treehouse" },
                    { 15, "Houseboats or other boats for a stay on the water", "https://localhost:7116/Assets/Category/16.jpg", "Boat" },
                    { 16, "Unique dome-shaped accommodations", "https://localhost:7116/Assets/Category/17.jpg", "Dome" },
                    { 17, "Small, stylish hotels with personalized service", "https://localhost:7116/Assets/Category/18.jpg", "Boutique Hotel" },
                    { 18, "Properties committed to sustainable practices", "https://localhost:7116/Assets/Category/19.jpg", "Eco-Friendly" },
                    { 19, "Properties with amenities for families with children", "https://localhost:7116/Assets/Category/20.jpg", "Family-Friendly" },
                    { 20, "Properties with features suitable for remote work (fast Wi-Fi, dedicated workspace)", "https://localhost:7116/Assets/Category/21.jpg", "Workcation-Friendly" },
                    { 21, "Description For Category", "https://localhost:7116/Assets/Category/1.jpg", "Apartment" }
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
                    { 15, 5, "Dubai" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Adress", "Beds", "CategoryId", "CheckIn", "CheckOut", "CityId", "Description", "DisplayedImage", "Name", "NumberOfBathrooms", "NumberOfBedrooms", "NumberOfGuest", "Pets", "Status", "TakePhotos", "UserId" },
                values: new object[,]
                {
                    { 1, "Cairo", 8, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 1, "No Description", "https://localhost:7116/Assets/Properties/1/1 (1).webp", "Apartment", 1, 4, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 2, "Alexandria", 5, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 2, "Sea view with modern amenities", "https://localhost:7116/Assets/Properties/2/1 (1).webp", "Beach House", 2, 3, 10, true, 2, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 3, "Aswan", 3, 2, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 3, "Cozy cabin in the mountains", "https://localhost:7116/Assets/Properties/3/1 (1).webp", "Mountain Cabin", 1, 2, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 4, "Sharm El-Sheikh", 10, 3, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 4, "Luxurious villa with a private pool", "https://localhost:7116/Assets/Properties/4/1 (1).jpeg", "Luxury Villa", 4, 5, 10, true, 3, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 5, "Giza", 4, 4, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 5, "Modern condo in the city center", "https://localhost:7116/Assets/Properties/5/1 (1).webp", "Downtown Condo", 2, 2, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 6, "Luxor", 7, 5, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 6, "Spacious farmhouse with a garden", "https://localhost:7116/Assets/Properties/6/1 (1).webp", "Farmhouse", 3, 4, 10, true, 2, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 7, "Cairo", 6, 6, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 1, "Penthouse with panoramic views", "https://localhost:7116/Assets/Properties/7/1 (1).webp", "Penthouse", 3, 3, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 8, "Helwan", 5, 7, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 8, "Family home in a quiet suburb", "https://localhost:7116/Assets/Properties/8/1 (1).webp", "Suburban Home", 2, 3, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 9, "Alexandria", 1, 8, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 2, "Compact studio in a bustling area", "https://localhost:7116/Assets/Properties/9/1 (1).webp", "Studio Apartment", 1, 1, 10, true, 3, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 10, "Minya", 3, 9, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 10, "Charming cottage in the countryside", "https://localhost:7116/Assets/Properties/10/1 (1).webp", "Country Cottage", 1, 2, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 11, "Fayoum", 5, 10, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 11, "Peaceful house by the lake", "https://localhost:7116/Assets/Properties/11/1 (1).webp", "Lake House", 2, 3, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 12, "Cairo", 2, 1, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 1, "Stylish loft in an urban setting", "https://localhost:7116/Assets/Properties/12/1 (1).webp", "Urban Loft", 1, 2, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 13, "Suez", 4, 2, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 13, "Modern townhouse with a garage", "https://localhost:7116/Assets/Properties/13/1 (1).webp", "Townhouse", 2, 3, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 14, "Alexandria", 7, 4, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 2, "Home with historical significance", "https://localhost:7116/Assets/Properties/14/1 (1).webp", "Historical Home", 3, 4, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 15, "Siwa", 3, 4, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 15, "Retreat in the quiet of the desert", "https://localhost:7116/Assets/Properties/15/1 (1).jpeg", "Desert Retreat", 1, 2, 10, true, 2, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 16, "Dahab", 4, 5, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 12, "Single-story bungalow with a yard", "https://localhost:7116/Assets/Properties/16/1 (1).webp", "Bungalow", 1, 3, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 17, "Cairo", 1, 6, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 1, "Modern flat in a residential complex", "https://localhost:7116/Assets/Properties/17/1 (1).webp", "Modern Flat", 1, 1, 10, true, 0, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 18, "Port Said", 5, 7, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 12, "Eco-friendly house with solar panels", "https://localhost:7116/Assets/Properties/18/1 (1).webp", "Eco-Friendly House", 2, 3, 10, true, 3, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 19, "Port Said", 5, 7, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 12, "Eco-friendly house with solar panels", "https://localhost:7116/Assets/Properties/19/1 (1).webp", "Eco-Friendly House", 2, 3, 10, true, 3, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" },
                    { 20, "Sinai", 3, 8, new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(9)), new TimeOnly(0, 0, 0).Add(TimeSpan.FromTicks(15)), 14, "Cabin with a rustic charm", "https://localhost:7116/Assets/Properties/20/1 (1).webp", "Rustic Cabin", 1, 2, 10, true, 2, false, "a9f8d4c8-bf56-4291-bb5c-e674abfb8bb9" }
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Description", "Name", "propertyId" },
                values: new object[,]
                {
                    { 1, "Large outdoor pool", "Swimming Pool", 1 },
                    { 2, "Fully equipped fitness center", "Gym", 1 },
                    { 3, "High-speed wireless internet", "WiFi", 1 },
                    { 4, "Secure parking area", "Parking", 1 },
                    { 5, "Central air conditioning system", "Air Conditioning", 5 },
                    { 6, "Central heating system", "Heating", 5 },
                    { 7, "Private balcony with a view", "Balcony", 5 },
                    { 8, "Allows pets", "Pet Friendly", 5 },
                    { 9, "Full-service spa", "Spa", 6 },
                    { 10, "Fully equipped kitchen", "Kitchen", 6 },
                    { 11, "In-unit washer and dryer", "Laundry", 6 },
                    { 12, "Elevator access", "Elevator", 6 },
                    { 13, "Wood-burning fireplace", "Fireplace", 7 },
                    { 14, "Outdoor BBQ area", "BBQ Area", 7 },
                    { 15, "Private hot tub", "Hot Tub", 7 },
                    { 16, "Private sauna", "Sauna", 7 },
                    { 17, "Private garden area", "Garden", 8 },
                    { 18, "Room with games and entertainment", "Game Room", 8 },
                    { 19, "24-hour security", "Security", 8 },
                    { 20, "Private home theater", "Theater Room", 8 },
                    { 21, "Large outdoor pool", "Swimming Pool", 2 },
                    { 22, "Fully equipped fitness center", "Gym", 2 },
                    { 23, "High-speed wireless internet", "WiFi", 2 },
                    { 24, "Secure parking area", "Parking", 2 },
                    { 25, "Large outdoor pool", "Swimming Pool", 4 },
                    { 26, "Fully equipped fitness center", "Gym", 4 },
                    { 27, "High-speed wireless internet", "WiFi", 4 },
                    { 28, "Secure parking area", "Parking", 4 },
                    { 31, "Large outdoor pool", "Swimming Pool", 3 },
                    { 32, "Fully equipped fitness center", "Gym", 3 },
                    { 33, "High-speed wireless internet", "WiFi", 3 },
                    { 34, "Secure parking area", "Parking", 3 }
                });

            migrationBuilder.InsertData(
                table: "AppointmentsAvailable",
                columns: new[] { "Id", "From", "IsAvailable", "PricePerNight", "PropertyId", "To" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 28, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6841), true, 20m, 1, new DateTime(2024, 7, 3, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6890) },
                    { 2, new DateTime(2024, 6, 29, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6901), true, 25m, 2, new DateTime(2024, 7, 4, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6902) },
                    { 3, new DateTime(2024, 6, 30, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6905), false, 30m, 3, new DateTime(2024, 7, 5, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6906) },
                    { 4, new DateTime(2024, 7, 1, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6908), true, 35m, 4, new DateTime(2024, 7, 6, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6909) },
                    { 5, new DateTime(2024, 7, 2, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6911), true, 40m, 5, new DateTime(2024, 7, 7, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6912) },
                    { 6, new DateTime(2024, 7, 3, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6914), false, 45m, 6, new DateTime(2024, 7, 8, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6916) },
                    { 7, new DateTime(2024, 7, 4, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6918), true, 50m, 7, new DateTime(2024, 7, 9, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6919) },
                    { 8, new DateTime(2024, 7, 5, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6921), true, 55m, 8, new DateTime(2024, 7, 10, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6922) },
                    { 9, new DateTime(2024, 7, 6, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6924), false, 60m, 9, new DateTime(2024, 7, 11, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6926) },
                    { 10, new DateTime(2024, 7, 7, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6928), true, 65m, 10, new DateTime(2024, 7, 12, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6929) },
                    { 11, new DateTime(2024, 7, 8, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6931), true, 70m, 11, new DateTime(2024, 7, 13, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6933) },
                    { 12, new DateTime(2024, 7, 9, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6934), false, 75m, 12, new DateTime(2024, 7, 14, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6936) },
                    { 13, new DateTime(2024, 7, 10, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6938), true, 80m, 13, new DateTime(2024, 7, 15, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6939) },
                    { 14, new DateTime(2024, 7, 11, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6941), true, 85m, 14, new DateTime(2024, 7, 16, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6942) },
                    { 15, new DateTime(2024, 7, 12, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6944), false, 90m, 15, new DateTime(2024, 7, 17, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6945) },
                    { 16, new DateTime(2024, 7, 13, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6947), true, 95m, 16, new DateTime(2024, 7, 18, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6948) },
                    { 17, new DateTime(2024, 7, 14, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6950), true, 100m, 17, new DateTime(2024, 7, 19, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6951) },
                    { 18, new DateTime(2024, 7, 15, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6953), false, 105m, 18, new DateTime(2024, 7, 20, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6954) },
                    { 19, new DateTime(2024, 7, 16, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6956), true, 110m, 19, new DateTime(2024, 7, 21, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6958) },
                    { 20, new DateTime(2024, 7, 17, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6959), true, 115m, 20, new DateTime(2024, 7, 22, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(6961) }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingStatus", "CheckInDate", "CheckOutDate", "ClientSecret", "PaymentIntentId", "PropertyId", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 6, 28, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 7, 3, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7012), null, null, 1, 100, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 2, 2, new DateTime(2024, 6, 29, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7014), new DateTime(2024, 7, 4, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7015), null, null, 2, 150, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 3, 2, new DateTime(2024, 6, 30, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 7, 5, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7019), null, null, 3, 200, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 4, 0, new DateTime(2024, 7, 1, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7021), new DateTime(2024, 7, 6, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7022), null, null, 4, 250, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 5, 2, new DateTime(2024, 7, 2, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 7, 7, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7025), null, null, 5, 300, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 6, 2, new DateTime(2024, 7, 3, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7027), new DateTime(2024, 7, 8, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7029), null, null, 6, 350, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 7, 0, new DateTime(2024, 7, 4, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 7, 9, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7032), null, null, 7, 400, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 8, 2, new DateTime(2024, 7, 5, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 7, 10, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7035), null, null, 8, 450, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 9, 2, new DateTime(2024, 7, 6, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7037), new DateTime(2024, 7, 11, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7039), null, null, 9, 500, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 10, 0, new DateTime(2024, 7, 7, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7041), new DateTime(2024, 7, 12, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7042), null, null, 10, 550, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 11, 2, new DateTime(2024, 7, 8, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 7, 13, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7045), null, null, 11, 600, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 12, 2, new DateTime(2024, 7, 9, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 7, 14, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7048), null, null, 12, 650, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 13, 0, new DateTime(2024, 7, 10, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 7, 15, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7052), null, null, 13, 700, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 14, 2, new DateTime(2024, 7, 11, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7054), new DateTime(2024, 7, 16, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7055), null, null, 14, 750, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 15, 2, new DateTime(2024, 7, 12, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 7, 17, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7058), null, null, 15, 800, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 16, 0, new DateTime(2024, 7, 13, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 7, 18, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7061), null, null, 16, 850, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 17, 2, new DateTime(2024, 7, 14, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 7, 19, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7065), null, null, 17, 900, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 18, 2, new DateTime(2024, 7, 15, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 7, 20, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7068), null, null, 18, 950, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 19, 0, new DateTime(2024, 7, 16, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7070), new DateTime(2024, 7, 21, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7071), null, null, 19, 1000, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 20, 2, new DateTime(2024, 7, 17, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 7, 22, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7074), null, null, 20, 1050, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 21, 0, new DateTime(2024, 6, 28, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7006), new DateTime(2024, 7, 3, 18, 49, 49, 790, DateTimeKind.Local).AddTicks(7008), null, null, 1, 100, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" }
                });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "Id", "ImageUrl", "PropertyId" },
                values: new object[,]
                {
                    { 1, "https://localhost:7116/Assets/Properties/1/1 (1).webp", 1 },
                    { 2, "https://localhost:7116/Assets/Properties/1/1 (2).webp", 1 },
                    { 3, "https://localhost:7116/Assets/Properties/1/1 (3).webp", 1 },
                    { 4, "https://localhost:7116/Assets/Properties/1/1 (4).webp", 1 },
                    { 5, "https://localhost:7116/Assets/Properties/1/1 (5).webp", 1 },
                    { 6, "https://localhost:7116/Assets/Properties/2/1 (1).webp", 2 },
                    { 7, "https://localhost:7116/Assets/Properties/2/1 (2).webp", 2 },
                    { 8, "https://localhost:7116/Assets/Properties/2/1 (3).webp", 2 },
                    { 9, "https://localhost:7116/Assets/Properties/2/1 (4).webp", 2 },
                    { 10, "https://localhost:7116/Assets/Properties/2/1 (5).webp", 2 },
                    { 11, "https://localhost:7116/Assets/Properties/3/1 (1).webp", 3 },
                    { 12, "https://localhost:7116/Assets/Properties/3/1 (2).webp", 3 },
                    { 13, "https://localhost:7116/Assets/Properties/3/1 (3).webp", 3 },
                    { 14, "https://localhost:7116/Assets/Properties/3/1 (4).webp", 3 },
                    { 15, "https://localhost:7116/Assets/Properties/3/1 (5).webp", 3 },
                    { 16, "https://localhost:7116/Assets/Properties/4/1 (1).jpeg", 4 },
                    { 17, "https://localhost:7116/Assets/Properties/4/1 (1).webp", 4 },
                    { 18, "https://localhost:7116/Assets/Properties/4/1 (2).webp", 4 },
                    { 19, "https://localhost:7116/Assets/Properties/4/1 (3).webp", 4 },
                    { 20, "https://localhost:7116/Assets/Properties/4/1 (4).webp", 4 },
                    { 21, "https://localhost:7116/Assets/Properties/5/1.jpeg", 5 },
                    { 22, "https://localhost:7116/Assets/Properties/5/2.webp", 5 },
                    { 23, "https://localhost:7116/Assets/Properties/5/3.jpeg", 5 },
                    { 24, "https://localhost:7116/Assets/Properties/5/4.webp", 5 },
                    { 25, "https://localhost:7116/Assets/Properties/5/5.webp", 5 },
                    { 26, "https://localhost:7116/Assets/Properties/6/1 (1).webp", 6 },
                    { 27, "https://localhost:7116/Assets/Properties/6/1 (2).webp", 6 },
                    { 28, "https://localhost:7116/Assets/Properties/6/1 (3).webp", 6 },
                    { 29, "https://localhost:7116/Assets/Properties/6/1 (4).webp", 6 },
                    { 30, "https://localhost:7116/Assets/Properties/6/1 (5).webp", 6 },
                    { 31, "https://localhost:7116/Assets/Properties/7/1 (1).webp", 7 },
                    { 32, "https://localhost:7116/Assets/Properties/7/1 (2).webp", 7 },
                    { 33, "https://localhost:7116/Assets/Properties/7/1 (3).webp", 7 },
                    { 34, "https://localhost:7116/Assets/Properties/7/1 (4).webp", 7 },
                    { 35, "https://localhost:7116/Assets/Properties/7/1 (5).webp", 7 },
                    { 36, "https://localhost:7116/Assets/Properties/8/1 (1).webp", 8 },
                    { 37, "https://localhost:7116/Assets/Properties/8/1 (2).webp", 8 },
                    { 38, "https://localhost:7116/Assets/Properties/8/1 (3).webp", 8 },
                    { 39, "https://localhost:7116/Assets/Properties/8/1 (4).webp", 8 },
                    { 40, "https://localhost:7116/Assets/Properties/8/1 (5).webp", 8 },
                    { 41, "https://localhost:7116/Assets/Properties/9/1 (1).webp", 9 },
                    { 42, "https://localhost:7116/Assets/Properties/9/1 (2).webp", 9 },
                    { 43, "https://localhost:7116/Assets/Properties/9/1 (3).webp", 9 },
                    { 44, "https://localhost:7116/Assets/Properties/9/1 (4).webp", 9 },
                    { 45, "https://localhost:7116/Assets/Properties/9/1 (5).webp", 9 },
                    { 46, "https://localhost:7116/Assets/Properties/10/1 (1).webp", 10 },
                    { 47, "https://localhost:7116/Assets/Properties/10/1 (2).webp", 10 },
                    { 48, "https://localhost:7116/Assets/Properties/10/1 (3).webp", 10 },
                    { 49, "https://localhost:7116/Assets/Properties/10/1 (4).webp", 10 },
                    { 50, "https://localhost:7116/Assets/Properties/10/1 (5).webp", 10 },
                    { 51, "https://localhost:7116/Assets/Properties/11/1 (1).webp", 11 },
                    { 52, "https://localhost:7116/Assets/Properties/11/1 (2).webp", 11 },
                    { 53, "https://localhost:7116/Assets/Properties/11/1 (3).webp", 11 },
                    { 54, "https://localhost:7116/Assets/Properties/11/1 (4).webp", 11 },
                    { 55, "https://localhost:7116/Assets/Properties/11/1 (5).webp", 11 },
                    { 56, "https://localhost:7116/Assets/Properties/12/1 (1).webp", 12 },
                    { 57, "https://localhost:7116/Assets/Properties/12/1 (2).webp", 12 },
                    { 58, "https://localhost:7116/Assets/Properties/12/1 (3).webp", 12 },
                    { 59, "https://localhost:7116/Assets/Properties/12/1 (4).webp", 12 },
                    { 60, "https://localhost:7116/Assets/Properties/12/1 (5).webp", 12 },
                    { 61, "https://localhost:7116/Assets/Properties/13/1 (1).webp", 13 },
                    { 62, "https://localhost:7116/Assets/Properties/13/1 (2).webp", 13 },
                    { 63, "https://localhost:7116/Assets/Properties/13/1 (3).webp", 13 },
                    { 64, "https://localhost:7116/Assets/Properties/13/1 (4).webp", 13 },
                    { 65, "https://localhost:7116/Assets/Properties/13/1 (5).webp", 13 },
                    { 66, "https://localhost:7116/Assets/Properties/14/1 (1).webp", 14 },
                    { 67, "https://localhost:7116/Assets/Properties/14/1 (2).webp", 14 },
                    { 68, "https://localhost:7116/Assets/Properties/14/1 (3).webp", 14 },
                    { 69, "https://localhost:7116/Assets/Properties/14/1 (4).webp", 14 },
                    { 70, "https://localhost:7116/Assets/Properties/14/1 (5).webp", 14 },
                    { 71, "https://localhost:7116/Assets/Properties/15/1 (1).webp", 15 },
                    { 72, "https://localhost:7116/Assets/Properties/15/1 (2).webp", 15 },
                    { 73, "https://localhost:7116/Assets/Properties/15/1 (3).webp", 15 },
                    { 74, "https://localhost:7116/Assets/Properties/15/1 (4).webp", 15 },
                    { 75, "https://localhost:7116/Assets/Properties/15/1 (5).webp", 15 },
                    { 76, "https://localhost:7116/Assets/Properties/16/1 (1).webp", 16 },
                    { 77, "https://localhost:7116/Assets/Properties/16/1 (2).webp", 16 },
                    { 78, "https://localhost:7116/Assets/Properties/16/1 (3).webp", 16 },
                    { 79, "https://localhost:7116/Assets/Properties/16/1 (4).webp", 16 },
                    { 80, "https://localhost:7116/Assets/Properties/16/1 (5).webp", 16 },
                    { 81, "https://localhost:7116/Assets/Properties/17/1 (1).webp", 17 },
                    { 82, "https://localhost:7116/Assets/Properties/17/1 (2).webp", 17 },
                    { 83, "https://localhost:7116/Assets/Properties/17/1 (3).webp", 17 },
                    { 84, "https://localhost:7116/Assets/Properties/17/1 (4).webp", 17 },
                    { 85, "https://localhost:7116/Assets/Properties/17/1 (5).webp", 17 },
                    { 86, "https://localhost:7116/Assets/Properties/18/1 (1).webp", 18 },
                    { 87, "https://localhost:7116/Assets/Properties/18/1 (2).webp", 18 },
                    { 88, "https://localhost:7116/Assets/Properties/18/1 (3).webp", 18 },
                    { 89, "https://localhost:7116/Assets/Properties/18/1 (4).webp", 18 },
                    { 90, "https://localhost:7116/Assets/Properties/18/1 (5).webp", 18 },
                    { 91, "https://localhost:7116/Assets/Properties/19/1 (1).webp", 19 },
                    { 92, "https://localhost:7116/Assets/Properties/19/1 (2).webp", 19 },
                    { 93, "https://localhost:7116/Assets/Properties/19/1 (3).webp", 19 },
                    { 94, "https://localhost:7116/Assets/Properties/19/1 (4).webp", 19 },
                    { 95, "https://localhost:7116/Assets/Properties/19/1 (5).webp", 19 },
                    { 96, "https://localhost:7116/Assets/Properties/20/1 (1).webp", 20 },
                    { 97, "https://localhost:7116/Assets/Properties/20/1 (2).webp", 20 },
                    { 98, "https://localhost:7116/Assets/Properties/20/1 (3).webp", 20 },
                    { 99, "https://localhost:7116/Assets/Properties/20/1 (4).webp", 20 },
                    { 100, "https://localhost:7116/Assets/Properties/20/1 (5).webp", 20 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookingId", "Comment", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Good Comment", 5, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 2, 2, "Nice place", 4, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 3, 3, "Average experience", 3, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 4, 4, "Not as expected", 2, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 5, 5, "Excellent service", 5, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 6, 6, "Good value for money", 4, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 7, 7, "Decent stay", 3, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 8, 8, "Terrible experience", 1, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 9, 9, "Highly recommend", 5, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 10, 10, "Very comfortable", 4, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 11, 11, "Could be better", 2, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 12, 12, "Loved the place", 5, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 13, 13, "It was okay", 3, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 14, 14, "Pretty good", 4, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 15, 15, "Needs improvement", 2, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 16, 16, "Fantastic stay", 5, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 17, 17, "Very disappointing", 1, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 18, 18, "Good location", 4, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 19, 19, "Not bad", 3, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" },
                    { 20, 20, "Amazing experience", 5, "9fc61a74-9ae4-482f-a7b8-8c70538f7418" }
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
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 34);

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
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 21);

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
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 100);

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
                table: "Countires",
                keyColumn: "Id",
                keyValue: 9);

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
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

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
                keyValue: 10);
        }
    }
}
