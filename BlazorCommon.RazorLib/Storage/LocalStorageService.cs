﻿using Microsoft.JSInterop;

namespace BlazorCommon.RazorLib.Storage;

public class LocalStorageService : IStorageService
{
    public bool IsEnabled { get; }
    private readonly IJSRuntime _jsRuntime;

    public LocalStorageService(
        bool isEnabled,
        IJSRuntime jsRuntime)
    {
        IsEnabled = isEnabled;
        _jsRuntime = jsRuntime;
    }
    
    public async ValueTask SetValue(string key, object? value)
    {
        await _jsRuntime.InvokeVoidAsync(
            "blazorShared.localStorageSetItem",
            key,
            value);
    }

    public async ValueTask<object?> GetValue(string key)
    {
        return await _jsRuntime.InvokeAsync<string>(
            "blazorShared.localStorageGetItem",
            key);
    }
}