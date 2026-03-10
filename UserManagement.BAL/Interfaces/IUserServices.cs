using Shared.DTOs;
using Shared.Results;

namespace UserManagement.BAL.Interfaces
{
    public interface IUserServices
    {
        Result<UserDto> CreateUser(UserDto userDto);
        Result<UserDto> UpdateUser(UserDto userDto);
        Result<UserDto> DeleteUser(Guid id);
        Result<UserDto> PrintAllUsers();
        Result<UserDto> PrintUserById(Guid id);
    }
}
