﻿using Domain.UserIdentity.Masters;

namespace Domain.Interfaces
{
    public interface IRequiredRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(UserMasterUserDtoCreate user);
        Task<T> GetById(Guid id, UserMasterUserDtoCreate user);
        Task<bool> Exists(T entity, UserMasterUserDtoCreate user);
    }
}
