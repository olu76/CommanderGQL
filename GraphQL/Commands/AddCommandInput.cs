using System;

namespace CommanderGQL.GraphQL.Commands
{
    public record AddCommandInput(String HowTo, string CommandLine, int PlatformId);
}