window.registerInstanceService = function (dotNetRef) {

    setTimeout(() => {
        dotNetRef.invokeMethodAsync(
            "Notify",
            "Hello from JavaScript (Service Instance)"
        );
    }, 1000);
};
window.callAddInstance = async function (dotNetRef) {

    const result = await dotNetRef.invokeMethodAsync(
        "Add",
        10,
        20
    );

    console.log("Result from .NET instance:", result);
    return result; // optional
};