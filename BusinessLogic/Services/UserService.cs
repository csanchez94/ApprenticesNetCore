using System.Collections.Generic;
using WebAPI.BusinessLogic.Contracts;
using System.Linq;
using System;

namespace WebAPI.Services
{
    public class UserService
    {
        private readonly IRepositoryManager _repository;

        public UserService(IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
        }

        public List<DTO.User> GetUsers()
        {
            var users = _repository.User.GetAll();
            
            
            return users.Select(x => x.ToDTO())
                .ToList();
        }

        public DTO.User GetuserById(Guid id)
        {
            var user = _repository.User.FindById(id);

            return user.ToDTO();
        }

        public void InsertUser(DTO.User user)
        {
            
            _repository.User.InsertUser(user);
        }
    }
}
