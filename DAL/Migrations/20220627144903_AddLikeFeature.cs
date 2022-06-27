using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AddLikeFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Email", "FullName", "Gender", "Interests", "Introduction", "LastActive", "LookingFor", "PasswordHash", "PasswordSalt", "RefreshToken", "RefreshTokenExpiryTime" },
                values: new object[,]
                {
                    { 1, " HN", "VN", new DateTime(2022, 6, 27, 21, 49, 3, 659, DateTimeKind.Local).AddTicks(9883), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bachduyhoang2k@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 27, 21, 49, 3, 659, DateTimeKind.Local).AddTicks(9890), "New Challengers", new byte[] { 183, 18, 115, 67, 15, 113, 157, 174, 132, 198, 114, 94, 89, 50, 37, 8, 190, 30, 30, 167, 68, 224, 46, 55, 56, 162, 145, 180, 122, 22, 185, 22, 67, 20, 118, 251, 70, 32, 160, 147, 16, 202, 87, 165, 61, 234, 225, 46, 71, 152, 193, 33, 81, 219, 240, 123, 10, 42, 242, 105, 254, 169, 196, 157 }, new byte[] { 109, 251, 237, 181, 74, 33, 2, 102, 57, 207, 249, 52, 225, 53, 60, 167, 40, 132, 94, 57, 181, 250, 237, 101, 251, 130, 121, 54, 238, 75, 191, 133, 5, 48, 131, 60, 124, 36, 255, 57, 120, 109, 253, 87, 173, 169, 78, 245, 120, 107, 69, 2, 37, 53, 69, 112, 139, 16, 31, 77, 116, 119, 46, 236, 52, 207, 180, 84, 25, 160, 3, 40, 174, 117, 86, 2, 213, 191, 193, 152, 132, 234, 51, 34, 253, 143, 207, 71, 82, 159, 37, 159, 70, 76, 113, 21, 110, 164, 47, 85, 23, 193, 86, 14, 206, 84, 169, 200, 107, 202, 149, 238, 94, 126, 249, 70, 119, 52, 90, 45, 16, 231, 241, 207, 238, 137, 215, 135 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, " HN", "VN", new DateTime(2022, 6, 27, 21, 49, 3, 659, DateTimeKind.Local).AddTicks(9935), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string@gmail.com", "Nguyen Van A", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 27, 21, 49, 3, 659, DateTimeKind.Local).AddTicks(9935), "New Challengers", new byte[] { 183, 18, 115, 67, 15, 113, 157, 174, 132, 198, 114, 94, 89, 50, 37, 8, 190, 30, 30, 167, 68, 224, 46, 55, 56, 162, 145, 180, 122, 22, 185, 22, 67, 20, 118, 251, 70, 32, 160, 147, 16, 202, 87, 165, 61, 234, 225, 46, 71, 152, 193, 33, 81, 219, 240, 123, 10, 42, 242, 105, 254, 169, 196, 157 }, new byte[] { 109, 251, 237, 181, 74, 33, 2, 102, 57, 207, 249, 52, 225, 53, 60, 167, 40, 132, 94, 57, 181, 250, 237, 101, 251, 130, 121, 54, 238, 75, 191, 133, 5, 48, 131, 60, 124, 36, 255, 57, 120, 109, 253, 87, 173, 169, 78, 245, 120, 107, 69, 2, 37, 53, 69, 112, 139, 16, 31, 77, 116, 119, 46, 236, 52, 207, 180, 84, 25, 160, 3, 40, 174, 117, 86, 2, 213, 191, 193, 152, 132, 234, 51, 34, 253, 143, 207, 71, 82, 159, 37, 159, 70, 76, 113, 21, 110, 164, 47, 85, 23, 193, 86, 14, 206, 84, 169, 200, 107, 202, 149, 238, 94, 126, 249, 70, 119, 52, 90, 45, 16, 231, 241, 207, 238, 137, 215, 135 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, " HN", "VN", new DateTime(2022, 6, 27, 21, 49, 3, 659, DateTimeKind.Local).AddTicks(9948), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string1@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 27, 21, 49, 3, 659, DateTimeKind.Local).AddTicks(9948), "New Challengers", new byte[] { 183, 18, 115, 67, 15, 113, 157, 174, 132, 198, 114, 94, 89, 50, 37, 8, 190, 30, 30, 167, 68, 224, 46, 55, 56, 162, 145, 180, 122, 22, 185, 22, 67, 20, 118, 251, 70, 32, 160, 147, 16, 202, 87, 165, 61, 234, 225, 46, 71, 152, 193, 33, 81, 219, 240, 123, 10, 42, 242, 105, 254, 169, 196, 157 }, new byte[] { 109, 251, 237, 181, 74, 33, 2, 102, 57, 207, 249, 52, 225, 53, 60, 167, 40, 132, 94, 57, 181, 250, 237, 101, 251, 130, 121, 54, 238, 75, 191, 133, 5, 48, 131, 60, 124, 36, 255, 57, 120, 109, 253, 87, 173, 169, 78, 245, 120, 107, 69, 2, 37, 53, 69, 112, 139, 16, 31, 77, 116, 119, 46, 236, 52, 207, 180, 84, 25, 160, 3, 40, 174, 117, 86, 2, 213, 191, 193, 152, 132, 234, 51, 34, 253, 143, 207, 71, 82, 159, 37, 159, 70, 76, 113, 21, 110, 164, 47, 85, 23, 193, 86, 14, 206, 84, 169, 200, 107, 202, 149, 238, 94, 126, 249, 70, 119, 52, 90, 45, 16, 231, 241, 207, 238, 137, 215, 135 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, " HN", "VN", new DateTime(2022, 6, 27, 21, 49, 3, 659, DateTimeKind.Local).AddTicks(9959), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "string2@gmail.com", "Bach Duy Hoang", "female", "Gym", "I'm an extrovert person", new DateTime(2022, 6, 27, 21, 49, 3, 659, DateTimeKind.Local).AddTicks(9959), "New Challengers", new byte[] { 183, 18, 115, 67, 15, 113, 157, 174, 132, 198, 114, 94, 89, 50, 37, 8, 190, 30, 30, 167, 68, 224, 46, 55, 56, 162, 145, 180, 122, 22, 185, 22, 67, 20, 118, 251, 70, 32, 160, 147, 16, 202, 87, 165, 61, 234, 225, 46, 71, 152, 193, 33, 81, 219, 240, 123, 10, 42, 242, 105, 254, 169, 196, 157 }, new byte[] { 109, 251, 237, 181, 74, 33, 2, 102, 57, 207, 249, 52, 225, 53, 60, 167, 40, 132, 94, 57, 181, 250, 237, 101, 251, 130, 121, 54, 238, 75, 191, 133, 5, 48, 131, 60, 124, 36, 255, 57, 120, 109, 253, 87, 173, 169, 78, 245, 120, 107, 69, 2, 37, 53, 69, 112, 139, 16, 31, 77, 116, 119, 46, 236, 52, 207, 180, 84, 25, 160, 3, 40, 174, 117, 86, 2, 213, 191, 193, 152, 132, 234, 51, 34, 253, 143, 207, 71, 82, 159, 37, 159, 70, 76, 113, 21, 110, 164, 47, 85, 23, 193, 86, 14, 206, 84, 169, 200, 107, 202, 149, 238, 94, 126, 249, 70, 119, 52, 90, 45, 16, 231, 241, 207, 238, 137, 215, 135 }, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
