using BusinessLogic.Domain;
using System;
using System.Collections.Generic;

namespace WebAPI.BusinessLogic.Contracts
{
    public interface IUserRepository
    {
        public List<User> GetAll();

        public void InsertUser(DTO.User user);

        public User FindById(Guid id);
    }
}
