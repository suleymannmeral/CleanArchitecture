﻿using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistence.Context;
using GenericRepository;


namespace CleanArchitecture.Persistence.Repositories;

public class UserRoleRepository : Repository<UserRole,AppDbContext>, IUserRoleRepository
{
    public UserRoleRepository(AppDbContext context) : base(context)
    {
    }

}
