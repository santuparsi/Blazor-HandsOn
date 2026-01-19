using HandsOnBlazorNavigationAndRouting.Models;

namespace HandsOnBlazorNavigationAndRouting.Services
{
    public interface IUserService
    {
        bool SignUp(User user);

        User? Validate(string email, string password);

        User? GetUser(string userId);

        List<User> GetAllUsers();
    }
}