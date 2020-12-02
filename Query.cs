using HotChocolate;

namespace hotchocolate_stitching
{
    public class Query
    {
        [GraphQLDescription("Returns 'Hello World'")]
        public string sayHello() => "Hello World";
    };
}