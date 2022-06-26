using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var hmac = new HMACSHA512();
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Email = "bachduyhoang2k@gmail.com",
                    FullName = "Bach Duy Hoang",
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("123456")),
                    PasswordSalt = hmac.Key,
                    DateOfBirth = new DateTime(),
                    Gender = "female",
                    Introduction = "I'm an extrovert person",
                    LookingFor = "New Challengers",
                    Interests = "Gym",
                    City = " HN",
                    Country = "VN"
                },
                new User()
                {
                    Id = 2,
                    Email = "string@gmail.com",
                    FullName = "Nguyen Van A",
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("123456")),
                    PasswordSalt = hmac.Key,
                    DateOfBirth = new DateTime(),
                    Gender = "female",
                    Introduction = "I'm an extrovert person",
                    LookingFor = "New Challengers",
                    Interests = "Gym",
                    City = " HN",
                    Country = "VN"
                },
                new User()
                {
                    Id = 3,
                    Email = "string1@gmail.com",
                    FullName = "Bach Duy Hoang",
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("123456")),
                    PasswordSalt = hmac.Key,
                    DateOfBirth = new DateTime(),
                    Gender = "female",
                    Introduction = "I'm an extrovert person",
                    LookingFor = "New Challengers",
                    Interests = "Gym",
                    City = " HN",
                    Country = "VN"
                },
                new User()
                {
                    Id = 4,
                    Email = "string2@gmail.com",
                    FullName = "Bach Duy Hoang",
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("123456")),
                    PasswordSalt = hmac.Key,
                    DateOfBirth = new DateTime(),
                    Gender = "female",
                    Introduction = "I'm an extrovert person",
                    LookingFor = "New Challengers",
                    Interests = "Gym",
                    City = " HN",
                    Country = "VN"
                }
            );
            modelBuilder.Entity<Photo>().HasData(
                new Photo()
                {
                   Id = 1,
                    Url = "https://randomuser.me/api/portraits/women/54.jpg",
                    IsMain = true,
                    PublicId = "1",
                    UserForeignKey  =1
                },
                new Photo()
                {
                    Id = 2,
                    Url = "https://randomuser.me/api/portraits/women/14.jpg",
                    IsMain = true,
                    PublicId = "2",
                    UserForeignKey = 2
                },
                new Photo()
                {
                    Id = 3,
                    Url = "https://randomuser.me/api/portraits/women/15.jpg",
                    IsMain = true,
                    PublicId = "3",
                    UserForeignKey = 3
                },
                new Photo()
                {
                    Id = 4,
                    Url = "https://randomuser.me/api/portraits/women/16.jpg",
                    IsMain = true,
                    PublicId = "4",
                    UserForeignKey = 4
                });
        }
    }
}
