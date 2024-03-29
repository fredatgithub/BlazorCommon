﻿namespace BlazorCommon.RazorLib.Notification;

public record NotificationKey(Guid Guid)
{
    public static NotificationKey NewNotificationKey()
    {
        return new(Guid.NewGuid());
    }
}