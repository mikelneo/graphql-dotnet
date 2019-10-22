using GraphQL.Types;
using GraphQL.Utilities;

namespace GraphQL.Tests.Utilities.Visitors
{
    /// <summary>
    /// Visitor for unit tests. Adds additional type to schema.
    /// </summary>
    public class RegisterTypeDirectiveVisitor : SchemaDirectiveVisitor
    {
        public override string Name => "registerType";

        public override void VisitSchema(Schema schema)
        {
            base.VisitSchema(schema);
            schema.RegisterType(new ObjectGraphType
            {
                Name = "TestAdditionalType"
            });
        }
    }
}
