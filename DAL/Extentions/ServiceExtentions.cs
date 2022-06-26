using DAL.AutoMapper;
using DAL.DTOs;
using DAL.Interface;
using DAL.Repositories;
using DAL.Services;
using DAL.Validators;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Extentions
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Cloudinary
            services.Configure<CloudinarySettings>(configuration.GetSection("CloudinarySetting"));

            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IPhotoService, PhotoService>();
            services.AddTransient<LogUserActivity>();
            services.AddTransient<IUserRepository, UserRepository>();

            //Auto Mapper
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            
            // Fluent Api
            services.AddControllers().AddFluentValidation(
                fv => fv.RegisterValidatorsFromAssemblyContaining<RegisterValidator>());
            return services;
        }
    }
}
