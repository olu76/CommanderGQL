using CommanderGQL.Models;
using HotChocolate;

namespace CommanderGQL.GraphQL
{
    public class Subscription
    {
        public Platform OnPlatformAdded([EventMessage] Platform platform) 
        {
           return platform; 
        }
    }
}