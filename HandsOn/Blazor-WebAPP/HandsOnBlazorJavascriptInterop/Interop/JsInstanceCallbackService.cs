using Microsoft.JSInterop;
namespace HandsOnBlazorJavascriptInterop.Interop
{
    public class JsInstanceCallbackService
    {
        public event Action<string>? OnMessageReceived;

        [JSInvokable]
        public void Notify(string message)
        {
            OnMessageReceived?.Invoke(message);// Invoke the event when a message is received from JavaScript
        }
        [JSInvokable]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

}
