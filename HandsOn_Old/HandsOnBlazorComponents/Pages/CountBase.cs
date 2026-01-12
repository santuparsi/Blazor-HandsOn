using Microsoft.AspNetCore.Components;

namespace HandsOnBlazorComponents.Pages
{
    public class CountBase:ComponentBase
    {
        protected int count;
        protected void Increment()
        {
            count++;
        }

    }
}
