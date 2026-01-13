namespace BlazorComponentCommunication
{
    public class AppState
    {
        public string Message { get; private set; }

        public event Action OnChange;

        public void SetMessage(string message)
        {
            Message = message;
            OnChange?.Invoke();
        }
    }

}
