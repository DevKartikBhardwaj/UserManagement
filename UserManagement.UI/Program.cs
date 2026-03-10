using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shared.Constants;
using UserManagement.BAL.Services;
using UserManagement.DAL.DatabaseContext;
using UserManagement.DAL.Repository;
using UserManagement.UI.Views;


var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(config.GetConnectionString("DefaultConnection"))
                .Options;
Console.WriteLine(config.GetConnectionString("DefaultConnection"));
var context = new AppDbContext(options);
var repo = new UserRepository(context);



var userService = new UserServices(repo);


var view = new UserView(userService);

Console.Write(Logging.welcomeMessage);
while (true)
{
    Console.Write(Logging.userMenu);
    string? input = Console.ReadLine();
    switch (input)
    {
        case "1":
            view.CreateUser();
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            Console.WriteLine("Exiting Application...");
            return;
        default:
            Console.Write(Logging.invalidInput);
            break;
    }
}