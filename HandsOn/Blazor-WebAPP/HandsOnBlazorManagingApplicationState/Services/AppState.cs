using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
namespace HandsOnBlazorManagingApplicationState.Services
{
    public class AppState
    {
        private readonly ProtectedSessionStorage _storage;

        public string? UserName { get; private set; }
        public string? Role { get; private set; }

        public event Action? OnChange;

        public AppState(ProtectedSessionStorage storage)
        {
            _storage = storage;
        }

        public async Task InitializeAsync()
        {
            var result = await _storage.GetAsync<AppStateDto>("app_state");

            if (result.Success && result.Value != null)
            {
                UserName = result.Value.UserName;
                Role = result.Value.Role;
            }
        }

        public async Task LoginAsync(string userName, string role)
        {
            UserName = userName;
            Role = role;

            await PersistAsync();
            Notify();
        }

        public async Task LogoutAsync()
        {
            UserName = null;
            Role = null;

            await _storage.DeleteAsync("app_state");
            Notify();
        }

        private async Task PersistAsync()
        {
            var dto = new AppStateDto
            {
                UserName = UserName,
                Role = Role
            };

            await _storage.SetAsync("app_state", dto);
        }

        private void Notify() => OnChange?.Invoke();
    }

}
