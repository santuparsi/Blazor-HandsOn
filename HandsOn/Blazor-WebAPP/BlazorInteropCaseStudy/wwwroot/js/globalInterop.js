window.callStaticDotNet = function () {
    DotNet.invokeMethodAsync(
        "BlazorDemoApp",
        "Notify",
        "Hello from JavaScript!"
    );
};
