using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Databases_2_Project2_Grocery_store.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Birthday = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Available = table.Column<bool>(type: "boolean", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Volume = table.Column<double>(type: "double precision", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    LoyaltyProgram = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_People_Id",
                        column: x => x.Id,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    HireDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_People_Id",
                        column: x => x.Id,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2", 0, new DateTime(1977, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0fb07ba7-b4cc-4991-878e-556411561624", null, false, "Bob", "Belcher", false, null, null, null, null, null, false, "aca6fdec-da97-4df7-b9a1-ad6ee5ec82c0", false, null },
                    { "3", 0, new DateTime(1954, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "5597bc42-ce97-48f5-8b18-44922bd5a29b", null, false, "Hank", "Hill", false, null, null, null, null, null, false, "bee1a936-53f2-4baa-9740-d8d6a3ce4bef", false, null },
                    { "1", 0, new DateTime(1980, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "9b81b640-ea47-4243-97d1-ff75eefb5dd9", null, false, "Jace", "Beleren", false, null, null, null, null, null, false, "fe92d666-169f-4410-ac07-2dc5a8e34f62", false, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Available", "Discriminator", "Name", "Price", "Type", "Volume" },
                values: new object[,]
                {
                    { 1, true, "Drink", "Tassay", 2.0, "Water", 0.5 },
                    { 3, true, "Drink", "Polmlek", 2.5, "Milk", 1.0 },
                    { 4, true, "Drink", "Orange Juice", 4.0, "Juice", 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Available", "Discriminator", "Name", "Price", "Type", "Weight" },
                values: new object[,]
                {
                    { 2, true, "Food", "PanPiek", 3.0, "Bread", 0.40000000000000002 },
                    { 5, true, "Food", "Red Apple", 2.5, "Fruit", 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "LoyaltyProgram" },
                values: new object[,]
                {
                    { "2", true },
                    { "3", false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "HireDate", "Location" },
                values: new object[] { "1", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poznan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
