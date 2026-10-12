using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AddIntegerProjection : IOperator
{
    public AddIntegerProjection(IEnumerable<IntegerProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerProjection> Values { get; }

    public IType Type => new TypeInteger();
}
