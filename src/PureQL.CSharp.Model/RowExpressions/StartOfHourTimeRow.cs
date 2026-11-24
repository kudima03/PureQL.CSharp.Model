using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfHour.time@row</c>.</summary>
public sealed record StartOfHourTimeRow : IOperator
{
    public StartOfHourTimeRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeTime();
}
