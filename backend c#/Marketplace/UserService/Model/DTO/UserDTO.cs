﻿namespace UserService.Model.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Role { get; set; } = null!;

        public bool isBanned { get; set; }

    }
}
