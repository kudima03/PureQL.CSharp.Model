using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateAddMonths.date@row</c>.</summary>
public sealed record DateAddMonthsDateRow : IOperator
{
    public DateAddMonthsDateRow(DateRow operand, IntegerRow months)
    {
        Operand = operand;
        Months = months;
    }

    public DateRow Operand { get; }

    public IntegerRow Months { get; }

    public IType Type => new TypeDate();
}
