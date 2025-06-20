﻿using CleanArchitecture.Domain.Dtos;
using MediatR;
namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
public sealed class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        // process

        return  new("Araç Başarıyla Üretildi");
    }
}
