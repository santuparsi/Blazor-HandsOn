namespace HandsOnBlazorNavigationAndRouting.Services
{
    public class AppState
    {
        public bool IsLoggedIn { get; private set; }
        public string? Role { get; private set; }

        public event Action? OnChange;

        public void Login(string role)
        {
            IsLoggedIn = true;
            Role = role;
            NotifyStateChanged();
        }

        public void Logout()
        {
            IsLoggedIn = false;
            Role = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
            => OnChange?.Invoke();
    }

}
