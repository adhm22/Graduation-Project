using Makani.Repositories.Implements;
using Makani.Repositories.Interfaces;
using Makani.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Makani.Controllers
{
    [Route("Makani/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUserRepository _UserRepository;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;

        UsersController(ICustomerRepository customerRepository, IUserRepository userRepository , UserManager<User> userManager , RoleManager<Role> roleManager , SignInManager<User> signInManager)
        {
            _customerRepository = customerRepository;
            _UserRepository = userRepository;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [HttpPost]
        [Route("~/Register")]
        public async Task<IActionResult> Register([FromForm] RegisterViewModel NewUser)
        {
            User user = new User() { UserName = NewUser.UserName, Email = NewUser.Email, PhoneNumber = NewUser.PhoneNumber };
            IdentityResult result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Customer");
                Customer customer = new Customer() { Name = user.UserName, Phone = user.PhoneNumber, UserId = user.Id };
                await _customerRepository.Create(customer);
                return RedirectToAction("Login", "Users");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("Register", error.Description);
                }
            }
            return BadRequest(ModelState);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm] LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return Ok(new { Message = "Login successful" });
            }
            else
            {
                return Unauthorized(new { Message = "Invalid login attempt" });
            }
        }
    }
}
