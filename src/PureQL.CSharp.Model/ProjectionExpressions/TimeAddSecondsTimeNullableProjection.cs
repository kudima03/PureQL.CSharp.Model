using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>timeAddSeconds.time.nullable@projection</c>.</summary>
public sealed record TimeAddSecondsTimeNullableProjection : IOperator
{
    public TimeAddSecondsTimeNullableProjection(
        TimeNullableProjection operand,
        DecimalNullableProjection seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public TimeNullableProjection Operand { get; }

    public DecimalNullableProjection Seconds { get; }

    public IType Type => new TypeTimeNullable();
}
