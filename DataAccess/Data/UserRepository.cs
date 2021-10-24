using DataAccess.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.BusinessLogic.Contracts;
using WebAPI.DataAccess.Models;
using Domain = BusinessLogic.Domain;

namespace WebAPI.DataAccess
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public Domain.User FindById(Guid id)
        {
            var user = FindByCondition(p => p.Id == id, false).FirstOrDefault();
            return user.ToDomainModel();
        }

        public List<Domain.User> GetAll()
        {
            var dbUsers = FindAll(false).ToList();
            return dbUsers.Select(x => x.ToDomainModel()).ToList();
        }

        public void InsertUser(DTO.User user)
        {
            try
            {
                User dataAccessUser = new User();

                dataAccessUser.FirstName = user.FirstName;
                dataAccessUser.LastName = user.LastName;
                dataAccessUser.Email = user.Email;
                //dataAccessUser.Id = Guid.NewGuid();
                Create(dataAccessUser);
                RepositoryContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }  
        }
    }
}
