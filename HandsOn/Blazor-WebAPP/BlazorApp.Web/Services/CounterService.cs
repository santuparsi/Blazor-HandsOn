namespace BlazorApp.Web.Services
{
    public class CounterService
    {
        public int CurrentCount { get; private set; }

        public void Increment()
        {
            CurrentCount++;
        }
    }

}
