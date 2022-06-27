using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class likeentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    CurrentUserId = table.Column<int>(type: "int", nullable: false),
                    LikedUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.CurrentUserId, x.LikedUserId });
                    table.ForeignKey(
                        name: "FK_Likes_User_CurrentUserId",
                        column: x => x.CurrentUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Likes_User_LikedUserId",
                        column: x => x.LikedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_LikedUserId",
                table: "Likes",
                column: "LikedUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Email", "FullName", "Gender", "Interests", "Introduction", "LastActive", "LookingFor", "PasswordHash", "PasswordSalt", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[,]
                {
                    { 1, " HN", "VN", new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bachduyhoang2k@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4381), "New Challengers", new byte[] { 189, 36, 167, 193, 223, 20, 140, 178, 52, 152, 36, 103, 211, 190, 13, 56, 176, 49, 72, 133, 17, 210, 40, 177, 27, 147, 151, 228, 230, 175, 48, 18, 173, 47, 139, 75, 240, 245, 147, 8, 192, 37, 13, 2, 222, 121, 248, 36, 54, 82, 144, 171, 253, 18, 111, 72, 195, 112, 27, 28, 84, 233, 226, 21 }, new byte[] { 237, 182, 143, 206, 187, 101, 112, 128, 210, 213, 71, 58, 2, 0, 139, 25, 223, 84, 120, 9, 114, 51, 193, 234, 251, 80, 172, 207, 219, 137, 127, 157, 248, 212, 245, 66, 164, 0, 0, 124, 127, 199, 230, 89, 216, 245, 236, 39, 65, 236, 186, 85, 44, 234, 215, 228, 236, 23, 11, 126, 88, 166, 166, 134, 103, 233, 120, 226, 93, 116, 207, 251, 187, 7, 33, 231, 89, 186, 198, 0, 97, 30, 159, 96, 27, 241, 50, 3, 12, 29, 10, 80, 53, 211, 77, 115, 169, 213, 16, 19, 219, 178, 215, 207, 127, 201, 152, 201, 69, 83, 64, 82, 165, 14, 82, 184, 82, 130, 96, 210, 54, 24, 133, 197, 86, 124, 59, 110 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, " HN", "VN", new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4422), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string@gmail.com", "Nguyen Van A", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4423), "New Challengers", new byte[] { 189, 36, 167, 193, 223, 20, 140, 178, 52, 152, 36, 103, 211, 190, 13, 56, 176, 49, 72, 133, 17, 210, 40, 177, 27, 147, 151, 228, 230, 175, 48, 18, 173, 47, 139, 75, 240, 245, 147, 8, 192, 37, 13, 2, 222, 121, 248, 36, 54, 82, 144, 171, 253, 18, 111, 72, 195, 112, 27, 28, 84, 233, 226, 21 }, new byte[] { 237, 182, 143, 206, 187, 101, 112, 128, 210, 213, 71, 58, 2, 0, 139, 25, 223, 84, 120, 9, 114, 51, 193, 234, 251, 80, 172, 207, 219, 137, 127, 157, 248, 212, 245, 66, 164, 0, 0, 124, 127, 199, 230, 89, 216, 245, 236, 39, 65, 236, 186, 85, 44, 234, 215, 228, 236, 23, 11, 126, 88, 166, 166, 134, 103, 233, 120, 226, 93, 116, 207, 251, 187, 7, 33, 231, 89, 186, 198, 0, 97, 30, 159, 96, 27, 241, 50, 3, 12, 29, 10, 80, 53, 211, 77, 115, 169, 213, 16, 19, 219, 178, 215, 207, 127, 201, 152, 201, 69, 83, 64, 82, 165, 14, 82, 184, 82, 130, 96, 210, 54, 24, 133, 197, 86, 124, 59, 110 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, " HN", "VN", new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4436), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string1@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4436), "New Challengers", new byte[] { 189, 36, 167, 193, 223, 20, 140, 178, 52, 152, 36, 103, 211, 190, 13, 56, 176, 49, 72, 133, 17, 210, 40, 177, 27, 147, 151, 228, 230, 175, 48, 18, 173, 47, 139, 75, 240, 245, 147, 8, 192, 37, 13, 2, 222, 121, 248, 36, 54, 82, 144, 171, 253, 18, 111, 72, 195, 112, 27, 28, 84, 233, 226, 21 }, new byte[] { 237, 182, 143, 206, 187, 101, 112, 128, 210, 213, 71, 58, 2, 0, 139, 25, 223, 84, 120, 9, 114, 51, 193, 234, 251, 80, 172, 207, 219, 137, 127, 157, 248, 212, 245, 66, 164, 0, 0, 124, 127, 199, 230, 89, 216, 245, 236, 39, 65, 236, 186, 85, 44, 234, 215, 228, 236, 23, 11, 126, 88, 166, 166, 134, 103, 233, 120, 226, 93, 116, 207, 251, 187, 7, 33, 231, 89, 186, 198, 0, 97, 30, 159, 96, 27, 241, 50, 3, 12, 29, 10, 80, 53, 211, 77, 115, 169, 213, 16, 19, 219, 178, 215, 207, 127, 201, 152, 201, 69, 83, 64, 82, 165, 14, 82, 184, 82, 130, 96, 210, 54, 24, 133, 197, 86, 124, 59, 110 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, " HN", "VN", new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4447), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string2@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4448), "New Challengers", new byte[] { 189, 36, 167, 193, 223, 20, 140, 178, 52, 152, 36, 103, 211, 190, 13, 56, 176, 49, 72, 133, 17, 210, 40, 177, 27, 147, 151, 228, 230, 175, 48, 18, 173, 47, 139, 75, 240, 245, 147, 8, 192, 37, 13, 2, 222, 121, 248, 36, 54, 82, 144, 171, 253, 18, 111, 72, 195, 112, 27, 28, 84, 233, 226, 21 }, new byte[] { 237, 182, 143, 206, 187, 101, 112, 128, 210, 213, 71, 58, 2, 0, 139, 25, 223, 84, 120, 9, 114, 51, 193, 234, 251, 80, 172, 207, 219, 137, 127, 157, 248, 212, 245, 66, 164, 0, 0, 124, 127, 199, 230, 89, 216, 245, 236, 39, 65, 236, 186, 85, 44, 234, 215, 228, 236, 23, 11, 126, 88, 166, 166, 134, 103, 233, 120, 226, 93, 116, 207, 251, 187, 7, 33, 231, 89, 186, 198, 0, 97, 30, 159, 96, 27, 241, 50, 3, 12, 29, 10, 80, 53, 211, 77, 115, 169, 213, 16, 19, 219, 178, 215, 207, 127, 201, 152, 201, 69, 83, 64, 82, 165, 14, 82, 184, 82, 130, 96, 210, 54, 24, 133, 197, 86, 124, 59, 110 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
        }
    }
}
