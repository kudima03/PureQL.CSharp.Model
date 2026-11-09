using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.decimal.nullable@projection</c>.</summary>
public sealed record CoalesceDecimalNullableProjection : IOperator
{
    public CoalesceDecimalNullableProjection(
        IEnumerable<IntegerNullableOrDecimalNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableOrDecimalNullableProjection> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
