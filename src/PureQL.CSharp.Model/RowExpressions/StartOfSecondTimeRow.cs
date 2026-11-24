using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfSecond.time@row</c>.</summary>
public sealed record StartOfSecondTimeRow : IOperator
{
    public StartOfSecondTimeRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeTime();
}
