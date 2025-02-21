﻿using Microsoft.AspNetCore.Identity;
using Planificalo.Backend.Repositories.Interfaces;
using Planificalo.Backend.UnitsOfWork.Interfaces;
using Planificalo.Shared.DTOs;
using Planificalo.Shared.Entities;
using Planificalo.Shared.Responses;

namespace Planificalo.Backend.UnitsOfWork.Implementations
{
    public class UsersUnitOfWork : IUsersUnitOfWork
    {
        private readonly IUsersRepository _usersRepository;

        public UsersUnitOfWork(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password) => await _usersRepository.AddUserAsync(user, password);

        public async Task AddUserToRoleAsync(User user, string roleName) => await _usersRepository.AddUserToRoleAsync(user, roleName);

        public async Task CheckRoleAsync(string roleName) => await _usersRepository.CheckRoleAsync(roleName);

        public async Task<IdentityResult> ConfirmEmailAsync(User user, string token) => await _usersRepository.ConfirmEmailAsync(user, token);

        public async Task<string> GenerateEmailConfirmationTokenAsync(User user) => await _usersRepository.GenerateEmailConfirmationTokenAsync(user);

        public async Task<User> GetUserAsync(string email) => await _usersRepository.GetUserAsync(email);

        public async Task<User> GetUserAsync(Guid userId) => await _usersRepository.GetUserAsync(userId);

        public async Task<bool> IsUserInRoleAsync(User user, string roleName) => await _usersRepository.IsUserInRoleAsync(user, roleName);

        public async Task<SignInResult> LoginAsync(LoginDTO model) => await _usersRepository.LoginAsync(model);

        public async Task LogoutAsync() => await _usersRepository.LogoutAsync();

        public async Task<IEnumerable<User>> GetAllUsersAsync() => await _usersRepository.GetAllUsersAsync();

        public async Task<ActionResponse<User>> UpdateUserAsync(User user) => await _usersRepository.UpdateUserAsync(user);

        public async Task<ActionResponse<User>> DeleteUserAsync(Guid userId) => await _usersRepository.DeleteUserAsync(userId);

        public async Task<ActionResponse<User>> ChangePasswordAsync(User user, string currentPassword, string newPassword) => await _usersRepository.ChangePasswordAsync(user, currentPassword, newPassword);
    }
}