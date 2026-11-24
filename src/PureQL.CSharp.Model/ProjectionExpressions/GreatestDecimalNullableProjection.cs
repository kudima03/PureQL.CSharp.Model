using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.decimal.nullable@projection</c>.</summary>
public sealed record GreatestDecimalNullableProjection : IOperator
{
    public GreatestDecimalNullableProjection(
        IEnumerable<DecimalNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
