﻿namespace BlazorCommon.RazorLib.ComponentRenderers.Types;

public interface IErrorNotificationRendererType
{
    public const string CSS_CLASS_STRING = "bcrl_error";
    public string Message { get; set; }
}