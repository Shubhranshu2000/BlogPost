using BlogPost.Models;

namespace BlogPost.Services.Interfaces
{
    public interface IUserService
    {
        public void AddUser(User user);
        public IEnumerable<User> GetUsers();
        public User GetUserById(int id);
        public User UpdateUser(int id, User user);
        public void DeleteUser(int id);
    }
}
