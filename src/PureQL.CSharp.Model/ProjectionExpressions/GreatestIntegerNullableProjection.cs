using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.integer.nullable@projection</c>.</summary>
public sealed record GreatestIntegerNullableProjection : IOperator
{
    public GreatestIntegerNullableProjection(
        IEnumerable<IntegerNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
