using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.boolean.nullable@projection</c>.</summary>
public sealed record GreatestBooleanNullableProjection : IOperator
{
    public GreatestBooleanNullableProjection(
        IEnumerable<BooleanNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableProjection> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
