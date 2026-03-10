using Shared.DTOs;
using Shared.Results;
using UserManagement.BAL.Interfaces;
using UserManagement.BAL.Mappers;
using UserManagement.DAL.Entities;
using UserManagement.DAL.Repository;

namespace UserManagement.BAL.Services
{

    public class UserServices(UserRepository repo) : IUserServices
    {
        private readonly UserRepository _repo = repo;

        public Result<UserDto> CreateUser(UserDto userDto)
        {
            Result<UserDto> result = new();
            try
            {
                _repo.Add(userDto.TOEntity());
                _repo.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result.hasError = true;
                result.ErrorMessage = "Having Problem while creating user";
            }
            return result;
        }

        public Result<UserDto> DeleteUser(Guid id)
        {
            Result<UserDto> result = new();
            try
            {
                _repo.Delete(id);
            }
            catch (Exception)
            {
                result.hasError = true;
                result.ErrorMessage = "Having Problem while creating user";
            }
            return result;
        }

        public Result<UserDto> PrintAllUsers()
        {

            Result<UserDto> result = new();
            try
            {
                List<User> users = _repo.GetAll();
                result.DataList = [..users.Select(u => new UserDto
                                    {
                                        Name = u.Name,
                                        Email = u.Email,
                                        Role = u.Role
                                    })];
            }
            catch (Exception)
            {
                result.hasError = true;
                result.ErrorMessage = "Having Problem fetching users";
            }
            return result;
        }

        public Result<UserDto> PrintUserById(Guid id)
        {

            Result<UserDto> result = new();
            try
            {
                User user = _repo.GetById(id);
                result.Data = new UserDto
                {
                    Name = user.Name,
                    Email = user.Email,
                    Role = user.Role
                };
            }
            catch (Exception)
            {
                result.hasError = true;
                result.ErrorMessage = "Having Problem fetching users";
            }

            return result;

        }

        public Result<UserDto> UpdateUser(UserDto userDto)
        {
            Result<UserDto> result = new();
            try
            {
                _repo.Update(userDto.TOEntity());
            }
            catch (Exception)
            {
                result.hasError = true;
                result.ErrorMessage = "Having Problem fetching users";
            }

            return result;

        }
    }
}
