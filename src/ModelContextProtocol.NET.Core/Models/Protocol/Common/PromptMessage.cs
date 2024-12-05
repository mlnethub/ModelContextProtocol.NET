﻿using ModelContextProtocol.NET.Core.Models.Protocol.Shared.Content;

namespace ModelContextProtocol.NET.Core.Models.Protocol.Common;

public record PromptMessage : ISamplingMessage
{
    public required Role Role { get; init; }
    public required Annotated Content { get; init; } // TextContent | ImageContent | EmbeddedResource
}
