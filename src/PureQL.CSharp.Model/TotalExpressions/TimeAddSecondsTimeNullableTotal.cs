using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>timeAddSeconds.time.nullable@total</c>.</summary>
public sealed record TimeAddSecondsTimeNullableTotal : IOperator
{
    public TimeAddSecondsTimeNullableTotal(
        TimeNullableTotal operand,
        DecimalNullableTotal seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public TimeNullableTotal Operand { get; }

    public DecimalNullableTotal Seconds { get; }

    public IType Type => new TypeTimeNullable();
}
