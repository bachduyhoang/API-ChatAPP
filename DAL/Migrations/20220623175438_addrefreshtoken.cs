using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class addrefreshtoken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LookingFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_User_UserForeignKey",
                        column: x => x.UserForeignKey,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Email", "FullName", "Gender", "Interests", "Introduction", "LastActive", "LookingFor", "PasswordHash", "PasswordSalt", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[,]
                {
                    { 1, " HN", "VN", new DateTime(2022, 6, 24, 0, 54, 38, 276, DateTimeKind.Local).AddTicks(1488), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bachduyhoang2k@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 24, 0, 54, 38, 276, DateTimeKind.Local).AddTicks(1496), "New Challengers", new byte[] { 104, 9, 26, 221, 188, 30, 30, 244, 234, 17, 72, 213, 85, 136, 128, 131, 47, 148, 30, 8, 174, 60, 203, 75, 48, 47, 77, 199, 167, 91, 212, 85, 219, 176, 248, 80, 119, 51, 185, 93, 202, 153, 142, 188, 228, 133, 20, 99, 124, 222, 149, 151, 230, 162, 240, 90, 87, 245, 209, 3, 24, 231, 112, 129 }, new byte[] { 10, 27, 128, 63, 137, 240, 236, 31, 111, 200, 15, 186, 3, 21, 167, 113, 219, 139, 43, 85, 171, 125, 176, 46, 143, 208, 123, 6, 253, 207, 71, 9, 118, 94, 151, 111, 120, 60, 179, 33, 196, 226, 71, 99, 59, 88, 143, 252, 54, 205, 168, 244, 89, 118, 88, 127, 241, 8, 171, 197, 240, 60, 49, 178, 183, 191, 21, 75, 189, 6, 98, 143, 118, 203, 117, 127, 180, 95, 65, 134, 154, 160, 27, 70, 78, 49, 238, 186, 123, 156, 177, 107, 107, 141, 229, 69, 9, 90, 249, 180, 38, 90, 116, 85, 24, 194, 252, 22, 187, 131, 229, 31, 88, 10, 4, 105, 121, 113, 97, 25, 239, 84, 99, 12, 160, 132, 218, 91 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, " HN", "VN", new DateTime(2022, 6, 24, 0, 54, 38, 276, DateTimeKind.Local).AddTicks(1541), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string@gmail.com", "Nguyen Van A", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 24, 0, 54, 38, 276, DateTimeKind.Local).AddTicks(1541), "New Challengers", new byte[] { 104, 9, 26, 221, 188, 30, 30, 244, 234, 17, 72, 213, 85, 136, 128, 131, 47, 148, 30, 8, 174, 60, 203, 75, 48, 47, 77, 199, 167, 91, 212, 85, 219, 176, 248, 80, 119, 51, 185, 93, 202, 153, 142, 188, 228, 133, 20, 99, 124, 222, 149, 151, 230, 162, 240, 90, 87, 245, 209, 3, 24, 231, 112, 129 }, new byte[] { 10, 27, 128, 63, 137, 240, 236, 31, 111, 200, 15, 186, 3, 21, 167, 113, 219, 139, 43, 85, 171, 125, 176, 46, 143, 208, 123, 6, 253, 207, 71, 9, 118, 94, 151, 111, 120, 60, 179, 33, 196, 226, 71, 99, 59, 88, 143, 252, 54, 205, 168, 244, 89, 118, 88, 127, 241, 8, 171, 197, 240, 60, 49, 178, 183, 191, 21, 75, 189, 6, 98, 143, 118, 203, 117, 127, 180, 95, 65, 134, 154, 160, 27, 70, 78, 49, 238, 186, 123, 156, 177, 107, 107, 141, 229, 69, 9, 90, 249, 180, 38, 90, 116, 85, 24, 194, 252, 22, 187, 131, 229, 31, 88, 10, 4, 105, 121, 113, 97, 25, 239, 84, 99, 12, 160, 132, 218, 91 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, " HN", "VN", new DateTime(2022, 6, 24, 0, 54, 38, 276, DateTimeKind.Local).AddTicks(1553), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string1@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 24, 0, 54, 38, 276, DateTimeKind.Local).AddTicks(1554), "New Challengers", new byte[] { 104, 9, 26, 221, 188, 30, 30, 244, 234, 17, 72, 213, 85, 136, 128, 131, 47, 148, 30, 8, 174, 60, 203, 75, 48, 47, 77, 199, 167, 91, 212, 85, 219, 176, 248, 80, 119, 51, 185, 93, 202, 153, 142, 188, 228, 133, 20, 99, 124, 222, 149, 151, 230, 162, 240, 90, 87, 245, 209, 3, 24, 231, 112, 129 }, new byte[] { 10, 27, 128, 63, 137, 240, 236, 31, 111, 200, 15, 186, 3, 21, 167, 113, 219, 139, 43, 85, 171, 125, 176, 46, 143, 208, 123, 6, 253, 207, 71, 9, 118, 94, 151, 111, 120, 60, 179, 33, 196, 226, 71, 99, 59, 88, 143, 252, 54, 205, 168, 244, 89, 118, 88, 127, 241, 8, 171, 197, 240, 60, 49, 178, 183, 191, 21, 75, 189, 6, 98, 143, 118, 203, 117, 127, 180, 95, 65, 134, 154, 160, 27, 70, 78, 49, 238, 186, 123, 156, 177, 107, 107, 141, 229, 69, 9, 90, 249, 180, 38, 90, 116, 85, 24, 194, 252, 22, 187, 131, 229, 31, 88, 10, 4, 105, 121, 113, 97, 25, 239, 84, 99, 12, 160, 132, 218, 91 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, " HN", "VN", new DateTime(2022, 6, 24, 0, 54, 38, 276, DateTimeKind.Local).AddTicks(1564), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string2@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 24, 0, 54, 38, 276, DateTimeKind.Local).AddTicks(1565), "New Challengers", new byte[] { 104, 9, 26, 221, 188, 30, 30, 244, 234, 17, 72, 213, 85, 136, 128, 131, 47, 148, 30, 8, 174, 60, 203, 75, 48, 47, 77, 199, 167, 91, 212, 85, 219, 176, 248, 80, 119, 51, 185, 93, 202, 153, 142, 188, 228, 133, 20, 99, 124, 222, 149, 151, 230, 162, 240, 90, 87, 245, 209, 3, 24, 231, 112, 129 }, new byte[] { 10, 27, 128, 63, 137, 240, 236, 31, 111, 200, 15, 186, 3, 21, 167, 113, 219, 139, 43, 85, 171, 125, 176, 46, 143, 208, 123, 6, 253, 207, 71, 9, 118, 94, 151, 111, 120, 60, 179, 33, 196, 226, 71, 99, 59, 88, 143, 252, 54, 205, 168, 244, 89, 118, 88, 127, 241, 8, 171, 197, 240, 60, 49, 178, 183, 191, 21, 75, 189, 6, 98, 143, 118, 203, 117, 127, 180, 95, 65, 134, 154, 160, 27, 70, 78, 49, 238, 186, 123, 156, 177, 107, 107, 141, 229, 69, 9, 90, 249, 180, 38, 90, 116, 85, 24, 194, 252, 22, 187, 131, 229, 31, 88, 10, 4, 105, 121, 113, 97, 25, 239, 84, 99, 12, 160, 132, 218, 91 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "Id", "IsMain", "PublicId", "Url", "UserForeignKey" },
                values: new object[,]
                {
                    { 1, true, "1", "https://randomuser.me/api/portraits/women/54.jpg", 1 },
                    { 2, true, "2", "https://randomuser.me/api/portraits/women/14.jpg", 2 },
                    { 3, true, "3", "https://randomuser.me/api/portraits/women/15.jpg", 3 },
                    { 4, true, "4", "https://randomuser.me/api/portraits/women/16.jpg", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_UserForeignKey",
                table: "Photo",
                column: "UserForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
