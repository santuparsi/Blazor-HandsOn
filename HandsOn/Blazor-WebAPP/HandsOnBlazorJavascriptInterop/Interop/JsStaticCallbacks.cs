using Microsoft.JSInterop;

namespace HandsOnBlazorJavascriptInterop.Interop
{
    public class JsStaticCallbacks
    {
        [JSInvokable] // This attribute makes the method callable from JavaScript
        public static void NotifyFromJs(string message)
        {
            Console.WriteLine($"Message from JavaScript: {message}");
        }

        [JSInvokable]
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        [JSInvokable]
        public static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }
    }
}
