using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.integer@projection</c>.</summary>
public sealed record LeastIntegerProjection : IOperator
{
    public LeastIntegerProjection(IEnumerable<IntegerProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerProjection> Values { get; }

    public IType Type => new TypeInteger();
}
