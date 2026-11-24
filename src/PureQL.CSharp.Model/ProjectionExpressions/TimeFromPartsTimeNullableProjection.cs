using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>timeFromParts.time.nullable@projection</c>.</summary>
public sealed record TimeFromPartsTimeNullableProjection : IOperator
{
    public TimeFromPartsTimeNullableProjection(
        IntegerNullableProjection hour,
        IntegerNullableProjection minute,
        DecimalNullableProjection second
    )
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public IntegerNullableProjection Hour { get; }

    public IntegerNullableProjection Minute { get; }

    public DecimalNullableProjection Second { get; }

    public IType Type => new TypeTimeNullable();
}
