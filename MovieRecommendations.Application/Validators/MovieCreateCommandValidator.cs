﻿using FluentValidation;
using MovieRecommendations.Application.Commands;

namespace MovieRecommendations.Application.Validators
{
    public class MovieCreateCommandValidator : AbstractValidator<MovieCreateCommand>
    {
        public MovieCreateCommandValidator()
        {
            RuleFor(c => c.Title)
                .NotEmpty()
                .WithMessage("Title shouldn't be empty");
        }
    }
}
