using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfMinute.time@row</c>.</summary>
public sealed record StartOfMinuteTimeRow : IOperator
{
    public StartOfMinuteTimeRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeTime();
}
