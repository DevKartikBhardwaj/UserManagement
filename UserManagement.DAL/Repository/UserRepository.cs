
using UserManagement.DAL.DatabaseContext;
using UserManagement.DAL.Entities;
using UserManagement.DAL.Interfaces;

namespace UserManagement.DAL.Repository
{
    public class UserRepository(AppDbContext context) : IUserRepository
    {
        private readonly AppDbContext _dbContext = context;

        public void Add(User user)
        {
            _dbContext.Users.Add(user);
        }

        public void Delete(Guid id)
        {
            User? user = _dbContext.Users.Find(id);
            if (user != null)
                _dbContext.Users.Remove(user);
        }

        public List<User> GetAll()
        {
            return [.. _dbContext.Users];
        }

        public User GetById(Guid id)
        {
            return _dbContext.Users.Find(id)!;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Update(User user)
        {
            _dbContext.Users.Update(user);
        }
    }
}
