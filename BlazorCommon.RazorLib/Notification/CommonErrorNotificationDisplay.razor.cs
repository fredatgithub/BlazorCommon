﻿using Microsoft.AspNetCore.Components;

namespace BlazorCommon.RazorLib.Notification;

public partial class CommonErrorNotificationDisplay : ComponentBase
{
    [Parameter, EditorRequired]
    public string Message { get; set; } = null!;
}