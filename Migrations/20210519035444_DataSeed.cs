using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Databases_2_Project2_Grocery_store.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "People");

            migrationBuilder.DropColumn(
                name: "LoyaltyProgram",
                table: "People");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                columns: new[] { "Id", "Birthday", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, new DateTime(1977, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", "Belcher" },
                    { 3, new DateTime(1954, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hank", "Hill" },
                    { 1, new DateTime(1980, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jace", "Beleren" }
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
                    { 2, true },
                    { 3, false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "HireDate", "Location" },
                values: new object[] { 1, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poznan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "People",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "People",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LoyaltyProgram",
                table: "People",
                type: "boolean",
                nullable: true);
        }
    }
}
