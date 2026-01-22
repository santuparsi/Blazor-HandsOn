window.callNotifyFromJsOnly = function () {

    // Call void static method
    DotNet.invokeMethodAsync(
        'HandsOnBlazorJavascriptInterop',
        'NotifyFromJs',
        'Hello from JavaScript!'
    );
};
window.callAddNumbersOnly = function () {
   const result= DotNet.invokeMethodAsync(
        'HandsOnBlazorJavascriptInterop',
        'AddNumbers',
        5,
        7
    )
    return result;
};
window.callMultiplyNumbersOnly = function (a, b) {
    const result = DotNet.invokeMethodAsync(
        'HandsOnBlazorJavascriptInterop',
        'MultiplyNumbers',
        a,
        b
    )
    return result;
};
