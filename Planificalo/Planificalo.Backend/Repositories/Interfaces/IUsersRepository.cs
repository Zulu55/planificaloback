﻿using Microsoft.AspNetCore.Identity;
using Planificalo.Shared.DTOs;
using Planificalo.Shared.Entities;

namespace Planificalo.Backend.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        Task<User> GetUserAsync(Guid userId);

        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);

        Task<SignInResult> LoginAsync(LoginDTO model);

        Task LogoutAsync();

        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<IEnumerable<User>> GetAllUsersAsync(); // Agregar este método
    }
}