using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>timeAddSeconds.time@row</c>.</summary>
public sealed record TimeAddSecondsTimeRow : IOperator
{
    public TimeAddSecondsTimeRow(TimeRow operand, DecimalRow seconds)
    {
        Operand = operand;
        Seconds = seconds;
    }

    public TimeRow Operand { get; }

    public DecimalRow Seconds { get; }

    public IType Type => new TypeTime();
}
