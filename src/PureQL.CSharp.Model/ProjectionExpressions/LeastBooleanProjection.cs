using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.boolean@projection</c>.</summary>
public sealed record LeastBooleanProjection : IOperator
{
    public LeastBooleanProjection(IEnumerable<BooleanProjection> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanProjection> Values { get; }

    public IType Type => new TypeBoolean();
}
