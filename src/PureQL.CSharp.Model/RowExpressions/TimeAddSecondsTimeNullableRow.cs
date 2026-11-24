using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>timeAddSeconds.time.nullable@row</c>.</summary>
public sealed record TimeAddSecondsTimeNullableRow : IOperator
{
    public TimeAddSecondsTimeNullableRow(
        TimeNullableRow operand,
        DecimalNullableRow seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public TimeNullableRow Operand { get; }

    public DecimalNullableRow Seconds { get; }

    public IType Type => new TypeTimeNullable();
}
