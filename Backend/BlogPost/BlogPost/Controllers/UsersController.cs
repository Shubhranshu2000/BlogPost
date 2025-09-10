using BlogPost.Models;
using BlogPost.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController: ControllerBase
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            IEnumerable<User> userList = _userService.GetUsers();
            return Ok(userList);
        }

        [HttpGet("id")]
        public IActionResult GetUserById(int id)
        {
            User user = _userService.GetUserById(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpPut("id")]
        public IActionResult UpdateUser(int id, User user)
        {
            User updatedUser = _userService.UpdateUser(id, user);
            if(updatedUser == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
