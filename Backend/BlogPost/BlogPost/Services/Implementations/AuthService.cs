using BlogPost.Data;
using BlogPost.Models;
using BlogPost.Services.Interfaces;

namespace BlogPost.Services.Implementations
{
    public class AuthService : IAuthService
    {

        private List<User> userList;

        public AuthService(UsersData usersData)
        {
            userList = usersData.UserList;
        }
        public string LoginUser(LoginUser loginUser)
        {
            User user = userList.FirstOrDefault(u => u.Email.ToLower().Equals(loginUser.Email.ToLower()));
            if(user != null)
            {
                return user.PasswordHash.Equals(loginUser.PasswordHash) ? "successfull" : "unsuccessfull";
            }
            return "unsuccessfull";
        }

        public void Logout(LoginUser loginUser)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(User user)
        {
            if(user != null)
            {
                userList.Add(user);
            }
        }
    }
}
