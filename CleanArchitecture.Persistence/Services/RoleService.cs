﻿using CleanArchitecture.Application.Features.RoleFeatures.Commands.CreateRole;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Identity;


namespace CleanArchitecture.Persistence.Services;

public sealed class RoleService : IRoleService
{
    private readonly RoleManager<Role> _roleManager;

    public RoleService(RoleManager<Role> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task CreateRoleAsync(CreateRoleCommand request)
    {
        Role role = new()
        {
            Name = request.Name,

        };
        await _roleManager.CreateAsync(role);
    }
}
