using BlogPost.Data;
using BlogPost.Models;
using BlogPost.Services.Interfaces;

namespace BlogPost.Services.Implementations
{
    public class UserService : IUserService
    {
        private List<User> userList;

        public UserService(UsersData usersData)
        {
            userList = usersData.UserList;
        }
        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public void DeleteUser(int id)
        {
            User user = GetUserById(id);
            if(user != null)
            {
                userList.Remove(user);
            }
        }

        public User GetUserById(int id)
        {
            return userList.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return userList;
        }

        public User UpdateUser(int id, User user)
        {
            User findUser = GetUserById(id);   
            if(findUser != null)
            {
                int idx = userList.IndexOf(findUser);
                userList[idx] = user;
                return user;
            }
            return null;
        }
    }
}
