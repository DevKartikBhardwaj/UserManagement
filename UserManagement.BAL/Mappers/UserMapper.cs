using Shared.DTOs;
using UserManagement.DAL.Entities;

namespace UserManagement.BAL.Mappers
{
    public static class UserMapper
    {
        extension(UserDto dto)
        {
            public User TOEntity()
            {
                return new User
                {
                    Name = dto.Name,
                    Email = dto.Email,
                    Password = dto.Password,
                    Role = dto.Role
                };
            }
        }
    }
}
