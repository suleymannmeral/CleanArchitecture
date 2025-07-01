﻿using FluentValidation;


namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.CreateNewTokenByRefreshToken;

public sealed class CreateNewTokenByRefreshTokenCommandValidator :
    AbstractValidator<CreateNewTokenByRefreshTokenCommand>
{
    public CreateNewTokenByRefreshTokenCommandValidator()
    {
        RuleFor(p => p.UserId).NotEmpty().WithMessage("User is required field");
        RuleFor(p => p.UserId).NotNull().WithMessage("User is required field");
        RuleFor(p => p.RefreshToken).NotNull().WithMessage("Refresh Token is required field");
        RuleFor(p => p.RefreshToken).NotEmpty().WithMessage("Refresh Token is required field");
    }
}
