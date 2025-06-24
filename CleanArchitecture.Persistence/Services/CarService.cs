﻿using AutoMapper;
using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistence.Context;
using GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Services;

public sealed class CarService : ICarService
{
    private readonly AppDbContext _appContext;
    private readonly ICarRepository _carRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CarService(AppDbContext appContext, IMapper mapper, ICarRepository carRepository, IUnitOfWork unitOfWork)
    {
        _appContext = appContext;
        _mapper = mapper;
        _carRepository = carRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
     
        Car car = _mapper.Map<Car>(request);
        //await _appContext.Set<Car>().AddAsync(car,cancellationToken);
        //await _appContext.SaveChangesAsync(cancellationToken);
        await _carRepository.AddAsync(car,cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<IList<Car>> GetAllAsync(GetAllCarQuery request, CancellationToken cancellationToken)
    {
        IList<Car> cars = await _carRepository.GetAll().ToListAsync(cancellationToken);
        return cars;
    }
}
