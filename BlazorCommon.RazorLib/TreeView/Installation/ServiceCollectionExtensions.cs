﻿using Microsoft.Extensions.DependencyInjection;

namespace BlazorCommon.RazorLib.TreeView.Installation;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTreeViewServices(
        this IServiceCollection services,
        Action<TreeViewServiceOptions>? configure = null)
    {
        var notificationServiceOptions = new TreeViewServiceOptions();

        configure?.Invoke(notificationServiceOptions);
        
        return services
            .AddSingleton<ITreeViewServiceOptions>(notificationServiceOptions)
            .AddScoped<ITreeViewService, TreeViewService>();
    }
}