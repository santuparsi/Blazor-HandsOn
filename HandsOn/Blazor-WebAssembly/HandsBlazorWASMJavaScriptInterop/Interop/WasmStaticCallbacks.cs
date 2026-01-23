using Microsoft.JSInterop;
namespace HandsBlazorWASMJavaScriptInterop.Interop
{
    public static class WasmStaticCallbacks
    {
        [JSInvokable]
        public static void Notify(string message)
        {
            Console.WriteLine($"JS says: {message}");
        }
        [JSInvokable]
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

}
