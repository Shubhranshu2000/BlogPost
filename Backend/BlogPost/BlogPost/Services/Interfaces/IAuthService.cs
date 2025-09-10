using BlogPost.Models;

namespace BlogPost.Services.Interfaces
{
    public interface IAuthService
    {
        public void RegisterUser(User user);
        public string LoginUser(LoginUser loginUser);
        public void Logout(LoginUser loginUser);    
    }
}
