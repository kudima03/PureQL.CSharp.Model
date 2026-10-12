using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record SubtractIntegerProjection : IOperator
{
    public SubtractIntegerProjection(IEnumerable<IntegerProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerProjection> Values { get; }

    public IType Type => new TypeInteger();
}
