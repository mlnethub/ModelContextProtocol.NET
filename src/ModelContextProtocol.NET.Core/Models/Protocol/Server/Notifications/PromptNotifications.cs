using ModelContextProtocol.NET.Core.Models.Protocol.Base;

namespace ModelContextProtocol.NET.Core.Models.Protocol.Server.Notifications;

public class PromptListChangedNotification : ServerNotification<NotificationParams>
{
    public override string Method => "notifications/prompts/list_changed";
}
