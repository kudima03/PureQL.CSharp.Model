using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfMonth.date@row</c>.</summary>
public sealed record StartOfMonthDateRow : IOperator
{
    public StartOfMonthDateRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeDate();
}
