using Shared.DTOs;
using Shared.Results;
using UserManagement.BAL.Services;

namespace UserManagement.UI.Views
{
    public class UserView(UserServices service)
    {
        private readonly UserServices _service = service;

        public void CreateUser()
        {
            UserDto userDto = new();
            Console.WriteLine("Enter UserName: ");
            userDto.Name = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            userDto.Email = Console.ReadLine();

            Console.WriteLine("Enter Password");
            userDto.Password = Console.ReadLine();

            Console.WriteLine("Enter Role: ");
            userDto.Password = Console.ReadLine();

            Result<UserDto> result = _service.CreateUser(userDto);

            if (result.hasError)
                Console.WriteLine(result.ErrorMessage);
            else
                Console.WriteLine("User registered!");
        }
    }
}
