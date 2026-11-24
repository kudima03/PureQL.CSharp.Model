using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>atan2.decimal.nullable@projection</c>.</summary>
public sealed record Atan2DecimalNullableProjection : IOperator
{
    public Atan2DecimalNullableProjection(
        DecimalNullableProjection y,
        DecimalNullableProjection x
    )
    {
        Y = y;
        X = x;
    }

    public DecimalNullableProjection Y { get; }

    public DecimalNullableProjection X { get; }

    public IType Type => new TypeDecimalNullable();
}
