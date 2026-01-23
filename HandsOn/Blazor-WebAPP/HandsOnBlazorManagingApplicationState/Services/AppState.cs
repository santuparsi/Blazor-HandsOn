using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
namespace HandsOnBlazorManagingApplicationState.Services
{
    public class AppState
    {
        public string? UserName { get; private set; }
        public string? Role { get; private set; }

        public event Action? OnChange;

        public void SetUser(string userName, string role)
        {
            UserName = userName;
            Role = role;
            NotifyStateChanged();
        }

        public void Clear()
        {
            UserName = null;
            Role = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
            => OnChange?.Invoke();
    }


}
