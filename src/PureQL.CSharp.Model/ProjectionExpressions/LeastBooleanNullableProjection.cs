using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.boolean.nullable@projection</c>.</summary>
public sealed record LeastBooleanNullableProjection : IOperator
{
    public LeastBooleanNullableProjection(IEnumerable<BooleanNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableProjection> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
