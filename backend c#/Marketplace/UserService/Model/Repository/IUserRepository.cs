﻿using UserService.Model.Entity;

namespace UserService.Model.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();

        Task<User?> GetById(int id);

        Task Create(User user);

        Task Update(int id, User user);

        Task DeleteById(int id);

        Task<User?> GetUserByLogin(string login);
    }
}
