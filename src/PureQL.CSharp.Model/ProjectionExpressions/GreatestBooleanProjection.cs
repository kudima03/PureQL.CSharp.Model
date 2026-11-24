using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.boolean@projection</c>.</summary>
public sealed record GreatestBooleanProjection : IOperator
{
    public GreatestBooleanProjection(IEnumerable<BooleanProjection> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanProjection> Values { get; }

    public IType Type => new TypeBoolean();
}
