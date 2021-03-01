using GraphQL.Types;
using NetCore_GraphQL.Data.Enums;

namespace NetCore_GraphQL.GraphQL.Types
{
    public class ProductTypeEnumType : EnumerationGraphType<EProductType>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of product";
        }
    }
}