using DAL.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Validators
{
    public class TokenRequestValidator : AbstractValidator<TokenRequestDTO>
    {
        public TokenRequestValidator()
        {
            RuleFor(x =>x.AccessToken).NotEmpty().WithMessage("AccessToken is not null");
            RuleFor(x => x.RefreshToken).NotEmpty().WithMessage("RefreshToken is not null");
        }
    }
}
