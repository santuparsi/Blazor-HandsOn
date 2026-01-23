window.callDotNetStatic = function () {

    // Call void static method
    DotNet.invokeMethodAsync(
        "HandsBlazorWASMJavaScriptInterop",   // Assembly name
        "Notify",
        "Hello from JavaScript (WASM)"
    );

    // Call static method that returns a value
    DotNet.invokeMethodAsync(
        "HandsBlazorWASMJavaScriptInterop",
        "Add",
        10,
        20
    ).then(result => {
        console.log("Result from .NET:", result);
    });
};
