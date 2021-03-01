using GraphQL.Types;
using NetCore_GraphQL.GraphQL.Types;
using NetCore_GraphQL.Repositories;

namespace NetCore_GraphQL.GraphQL
{
    public class GraphQLQuery : ObjectGraphType
    {
        public GraphQLQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>("products", resolve: context => productRepository.GetAll());
        }
    }
}