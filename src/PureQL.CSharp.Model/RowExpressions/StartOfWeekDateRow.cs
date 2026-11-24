using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfWeek.date@row</c>.</summary>
public sealed record StartOfWeekDateRow : IOperator
{
    public StartOfWeekDateRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeDate();
}
