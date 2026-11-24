using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.integer@projection</c>.</summary>
public sealed record GreatestIntegerProjection : IOperator
{
    public GreatestIntegerProjection(IEnumerable<IntegerProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerProjection> Values { get; }

    public IType Type => new TypeInteger();
}
