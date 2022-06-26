using DAL.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Validators
{
    public class LoginValidator : AbstractValidator<LoginDTO>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email is not empty")
                .EmailAddress().WithMessage("Must be an email address");
            RuleFor(x => x.Password).NotNull().WithMessage("Password is not empty")
                .MinimumLength(6).WithMessage("Password must be greater than 6 characters"); ;
        }
    }
}
