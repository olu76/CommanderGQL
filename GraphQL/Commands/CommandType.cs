using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace CommandGQL.GraphQL.Commands
{
    public class CommandType : ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            descriptor.Description("Represents any executable command");

            descriptor
                .Field(c => c.Platform)
                .ResolveWith<Resolvers>(c => Resolvers.GetPlatform(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the Platform to which the command belong");
        }

        private class  Resolvers
        {
            public static Platform  GetPlatform(Command command, [ScopedService] AppDbContext context)
            {
                return context.Platform.FirstOrDefault(p => p.Id == command.PlatformId);
            }
        }
    }
}
        