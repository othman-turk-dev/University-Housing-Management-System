using Business_Layer.Authorization;
using Business_Layer.DTOs;
using Business_Layer.Global.Enums;
using Business_Layer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace University_Housing_Management_Project.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/Users")]
    [EnableRateLimiting("ApiLimiter")]
    [Permission(UserPermission.UserManagment)]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;
        public UsersController(IUserService userService)
            => _userService = userService;

        
        [HttpPost()]
        public async Task<ActionResult<UserDto>> AddUser([FromBody] UserDto user)
        {

            if (user == null || string.IsNullOrWhiteSpace(user.Username) ||
                string.IsNullOrWhiteSpace(user.Password))

                return BadRequest("User data is invalid.");


            if (await _userService.IsUserExistAsync(user.Username))
                return BadRequest("user with the same Username already exists.");


            var addedUser = await _userService.AddUserAsync(user);

            if (addedUser != null)
                return CreatedAtRoute("GetUserById", new { Id = addedUser.UserId }, addedUser);


            return BadRequest("Faild to added the user.");
        }

        [HttpPut("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto dto)
        {
            
            if (dto == null)
                return BadRequest();

            var result = await _userService.ChangePasswordAsync(
                dto.UserId,
                dto.CurrentPassword,
                dto.NewPassword);

            if (result)
                return NoContent();

            return BadRequest("Current password is incorrect.");
        }
        
        [HttpPut()]
        public async Task<ActionResult<SimpleUserDto>> UpdateUser(SimpleUserDto user)
        {

            if (user == null || user.UserId < 0 ||
                string.IsNullOrWhiteSpace(user.Username) )

                return BadRequest("User data is invalid.");


            if (!await _userService.IsUserExistAsync(user.UserId))
                return NotFound($"User with ID {user.UserId} not found.");

            var updateUser = await _userService.UpdateUserAsync(user);

            if (updateUser != null) return Ok(updateUser);

            return NotFound($"User with username {user.Username} update failed.");
        }

        [HttpPut("SetActive/{Id}")]
        public async Task<IActionResult> SetActive(int Id)
        {

            if (! await _userService.IsUserExistAsync(Id))
                return NotFound($"User with ID {Id} not found.");

            var updateActive = await _userService.ChangeUserStatusAsync(Id, true);
           
            if (updateActive) 
                return NoContent();

            return NotFound($"User with ID {Id} update failed.");
        }

        [HttpPut("SetInActive/{Id}")]
        public async Task<IActionResult> SetInActive(int Id)
        {

            if (!await _userService.IsUserExistAsync(Id))
                return NotFound($"User with ID {Id} not found.");

            var updateActive = await _userService.ChangeUserStatusAsync(Id, false);

            if (updateActive)
                return NoContent();

            return NotFound($"User with ID {Id} update failed.");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {

            if (id <= 0) 
                return BadRequest("Invalid id.");

            if (!await _userService.IsUserExistAsync(id))
                return NotFound($"User with id {id} not found.");

            var result = await _userService.DeleteUserAsync(id);

            if (!result)
                return NotFound($"user with ID {id} deletion failed.");

            return NoContent();
        }

        [HttpGet("{Id}", Name = "GetUserById")]
        public async Task<ActionResult<SimpleUserDto>> GetById(int Id)
        {

            if (Id <= 0)
                return BadRequest("Invalid user ID.");

            var User = await _userService.GetUserByIdAsync(Id);

            if (User == null)
                return NotFound($"User with ID {Id} not found.");

            return Ok(User);
        }

        [AllowAnonymous]
        [HttpGet("CurrentUser")]
        public async Task<ActionResult<SimpleUserDto>> GetCurrentUser()
        {
            return Ok(await _userService.GetCurrentUserAsync());
        }

        [HttpGet("IsExist/{Id}")]
        public async Task<ActionResult<bool>> IsUserExist(int Id)
        {

            if (Id <= 0)
                return BadRequest("Invalid user ID.");

            var exists = await _userService.IsUserExistAsync(Id);

            if (!exists)
                return NotFound($"User with ID {Id} does not exist.");

            return Ok(exists);
        }

        [HttpGet("IsExist/Username/{Id}")]
        public async Task<ActionResult<bool>> IsUserExist(string username)
        {

            if (string.IsNullOrWhiteSpace(username))
                return BadRequest("Invalid username.");

            var exists = await _userService.IsUserExistAsync(username);

            if (!exists)
                return NotFound($"User with username {username} does not exist.");

            return Ok(exists);
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<CustomUserDto>>> GetAllUsers()
        {

            return Ok(await _userService.GetAllUsersAsync());
        }

        [HttpGet("Filter")]
        public async Task<ActionResult<IEnumerable<CustomUserDto>>> FilterUsers([FromQuery] string? username)
        {

            return Ok(await _userService.UsersFilterAsync(username));
        }


    }
}
