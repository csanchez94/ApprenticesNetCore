using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<DTO.User> Get()
        {
            return _userService.GetUsers();
        }

        [HttpGet("{id}")]
        public DTO.User GetById(Guid id)
        {
            return _userService.GetuserById(id);
        }

        [HttpPost]
        public void Post(DTO.User user )
        {
            _userService.InsertUser(user);
        }


    }
}
