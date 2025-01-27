﻿namespace BusinessLogic.Domain
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public DTO.User ToDTO()
        {
            return new DTO.User()
            {
                UserId = Id,
                Email = Email,
                FirstName = FirstName,
                LastName = LastName
            };
        }

    }
}
