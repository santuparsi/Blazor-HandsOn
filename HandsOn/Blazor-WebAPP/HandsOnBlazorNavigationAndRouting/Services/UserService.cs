using HandsOnBlazorNavigationAndRouting.Models;

namespace HandsOnBlazorNavigationAndRouting.Services
{
    public class UserService:IUserService
    {
        private readonly List<User> _users = new()
        {
            new User(){UserId="U0001",Username="Karan",Password="12345",Role="Admin",Email="Karan@gmail.com"},
              new User(){UserId="U0002",Username="Ram",Password="12345",Role="User",Email="Ram@gmail.com"}
        };

        public bool SignUp(User user)
        {
            var exists = _users.Any(u =>
                u.Username.Equals(user.Username, StringComparison.OrdinalIgnoreCase));

            if (exists)
                return false;

            _users.Add(user);
            return true;
        }

        public User? Validate(string email, string password)
        {
            return _users.FirstOrDefault(u =>
                u.Email==email &&
                u.Password == password);
        }

        public User? GetUser(string userId)
        {
            return _users.FirstOrDefault(u => u.UserId == userId);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}
