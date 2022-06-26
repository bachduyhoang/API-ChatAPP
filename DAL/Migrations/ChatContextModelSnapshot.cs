﻿// <auto-generated />
using System;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ChatContext))]
    partial class ChatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserForeignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("Photo", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsMain = true,
                            PublicId = "1",
                            Url = "https://randomuser.me/api/portraits/women/54.jpg",
                            UserForeignKey = 1
                        },
                        new
                        {
                            Id = 2,
                            IsMain = true,
                            PublicId = "2",
                            Url = "https://randomuser.me/api/portraits/women/14.jpg",
                            UserForeignKey = 2
                        },
                        new
                        {
                            Id = 3,
                            IsMain = true,
                            PublicId = "3",
                            Url = "https://randomuser.me/api/portraits/women/15.jpg",
                            UserForeignKey = 3
                        },
                        new
                        {
                            Id = 4,
                            IsMain = true,
                            PublicId = "4",
                            Url = "https://randomuser.me/api/portraits/women/16.jpg",
                            UserForeignKey = 4
                        });
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("LookingFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = " HN",
                            Country = "VN",
                            Created = new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4373),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bachduyhoang2k@gmail.com",
                            FullName = "Bach Duy Hoang",
                            Gender = "female",
                            Interests = "Gym",
                            Introduction = "I'm an extrovert person",
                            LastActive = new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4381),
                            LookingFor = "New Challengers",
                            PasswordHash = new byte[] { 189, 36, 167, 193, 223, 20, 140, 178, 52, 152, 36, 103, 211, 190, 13, 56, 176, 49, 72, 133, 17, 210, 40, 177, 27, 147, 151, 228, 230, 175, 48, 18, 173, 47, 139, 75, 240, 245, 147, 8, 192, 37, 13, 2, 222, 121, 248, 36, 54, 82, 144, 171, 253, 18, 111, 72, 195, 112, 27, 28, 84, 233, 226, 21 },
                            PasswordSalt = new byte[] { 237, 182, 143, 206, 187, 101, 112, 128, 210, 213, 71, 58, 2, 0, 139, 25, 223, 84, 120, 9, 114, 51, 193, 234, 251, 80, 172, 207, 219, 137, 127, 157, 248, 212, 245, 66, 164, 0, 0, 124, 127, 199, 230, 89, 216, 245, 236, 39, 65, 236, 186, 85, 44, 234, 215, 228, 236, 23, 11, 126, 88, 166, 166, 134, 103, 233, 120, 226, 93, 116, 207, 251, 187, 7, 33, 231, 89, 186, 198, 0, 97, 30, 159, 96, 27, 241, 50, 3, 12, 29, 10, 80, 53, 211, 77, 115, 169, 213, 16, 19, 219, 178, 215, 207, 127, 201, 152, 201, 69, 83, 64, 82, 165, 14, 82, 184, 82, 130, 96, 210, 54, 24, 133, 197, 86, 124, 59, 110 },
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            City = " HN",
                            Country = "VN",
                            Created = new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4422),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "string@gmail.com",
                            FullName = "Nguyen Van A",
                            Gender = "female",
                            Interests = "Gym",
                            Introduction = "I'm an extrovert person",
                            LastActive = new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4423),
                            LookingFor = "New Challengers",
                            PasswordHash = new byte[] { 189, 36, 167, 193, 223, 20, 140, 178, 52, 152, 36, 103, 211, 190, 13, 56, 176, 49, 72, 133, 17, 210, 40, 177, 27, 147, 151, 228, 230, 175, 48, 18, 173, 47, 139, 75, 240, 245, 147, 8, 192, 37, 13, 2, 222, 121, 248, 36, 54, 82, 144, 171, 253, 18, 111, 72, 195, 112, 27, 28, 84, 233, 226, 21 },
                            PasswordSalt = new byte[] { 237, 182, 143, 206, 187, 101, 112, 128, 210, 213, 71, 58, 2, 0, 139, 25, 223, 84, 120, 9, 114, 51, 193, 234, 251, 80, 172, 207, 219, 137, 127, 157, 248, 212, 245, 66, 164, 0, 0, 124, 127, 199, 230, 89, 216, 245, 236, 39, 65, 236, 186, 85, 44, 234, 215, 228, 236, 23, 11, 126, 88, 166, 166, 134, 103, 233, 120, 226, 93, 116, 207, 251, 187, 7, 33, 231, 89, 186, 198, 0, 97, 30, 159, 96, 27, 241, 50, 3, 12, 29, 10, 80, 53, 211, 77, 115, 169, 213, 16, 19, 219, 178, 215, 207, 127, 201, 152, 201, 69, 83, 64, 82, 165, 14, 82, 184, 82, 130, 96, 210, 54, 24, 133, 197, 86, 124, 59, 110 },
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            City = " HN",
                            Country = "VN",
                            Created = new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4436),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "string1@gmail.com",
                            FullName = "Bach Duy Hoang",
                            Gender = "female",
                            Interests = "Gym",
                            Introduction = "I'm an extrovert person",
                            LastActive = new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4436),
                            LookingFor = "New Challengers",
                            PasswordHash = new byte[] { 189, 36, 167, 193, 223, 20, 140, 178, 52, 152, 36, 103, 211, 190, 13, 56, 176, 49, 72, 133, 17, 210, 40, 177, 27, 147, 151, 228, 230, 175, 48, 18, 173, 47, 139, 75, 240, 245, 147, 8, 192, 37, 13, 2, 222, 121, 248, 36, 54, 82, 144, 171, 253, 18, 111, 72, 195, 112, 27, 28, 84, 233, 226, 21 },
                            PasswordSalt = new byte[] { 237, 182, 143, 206, 187, 101, 112, 128, 210, 213, 71, 58, 2, 0, 139, 25, 223, 84, 120, 9, 114, 51, 193, 234, 251, 80, 172, 207, 219, 137, 127, 157, 248, 212, 245, 66, 164, 0, 0, 124, 127, 199, 230, 89, 216, 245, 236, 39, 65, 236, 186, 85, 44, 234, 215, 228, 236, 23, 11, 126, 88, 166, 166, 134, 103, 233, 120, 226, 93, 116, 207, 251, 187, 7, 33, 231, 89, 186, 198, 0, 97, 30, 159, 96, 27, 241, 50, 3, 12, 29, 10, 80, 53, 211, 77, 115, 169, 213, 16, 19, 219, 178, 215, 207, 127, 201, 152, 201, 69, 83, 64, 82, 165, 14, 82, 184, 82, 130, 96, 210, 54, 24, 133, 197, 86, 124, 59, 110 },
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            City = " HN",
                            Country = "VN",
                            Created = new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4447),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "string2@gmail.com",
                            FullName = "Bach Duy Hoang",
                            Gender = "female",
                            Interests = "Gym",
                            Introduction = "I'm an extrovert person",
                            LastActive = new DateTime(2022, 6, 24, 0, 58, 56, 948, DateTimeKind.Local).AddTicks(4448),
                            LookingFor = "New Challengers",
                            PasswordHash = new byte[] { 189, 36, 167, 193, 223, 20, 140, 178, 52, 152, 36, 103, 211, 190, 13, 56, 176, 49, 72, 133, 17, 210, 40, 177, 27, 147, 151, 228, 230, 175, 48, 18, 173, 47, 139, 75, 240, 245, 147, 8, 192, 37, 13, 2, 222, 121, 248, 36, 54, 82, 144, 171, 253, 18, 111, 72, 195, 112, 27, 28, 84, 233, 226, 21 },
                            PasswordSalt = new byte[] { 237, 182, 143, 206, 187, 101, 112, 128, 210, 213, 71, 58, 2, 0, 139, 25, 223, 84, 120, 9, 114, 51, 193, 234, 251, 80, 172, 207, 219, 137, 127, 157, 248, 212, 245, 66, 164, 0, 0, 124, 127, 199, 230, 89, 216, 245, 236, 39, 65, 236, 186, 85, 44, 234, 215, 228, 236, 23, 11, 126, 88, 166, 166, 134, 103, 233, 120, 226, 93, 116, 207, 251, 187, 7, 33, 231, 89, 186, 198, 0, 97, 30, 159, 96, 27, 241, 50, 3, 12, 29, 10, 80, 53, 211, 77, 115, 169, 213, 16, 19, 219, 178, 215, 207, 127, 201, 152, 201, 69, 83, 64, 82, 165, 14, 82, 184, 82, 130, 96, 210, 54, 24, 133, 197, 86, 124, 59, 110 },
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DAL.Entities.Photo", b =>
                {
                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
