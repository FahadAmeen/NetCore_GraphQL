using System;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore_GraphQL.GraphQL
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<GraphQLQuery>();
        }
    }
}