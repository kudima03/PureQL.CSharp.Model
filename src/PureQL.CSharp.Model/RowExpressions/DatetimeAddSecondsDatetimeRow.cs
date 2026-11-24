using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime@row</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeRow : IOperator
{
    public DatetimeAddSecondsDatetimeRow(DatetimeRow operand, DecimalRow seconds)
    {
        Operand = operand;
        Seconds = seconds;
    }

    public DatetimeRow Operand { get; }

    public DecimalRow Seconds { get; }

    public IType Type => new TypeDatetime();
}
