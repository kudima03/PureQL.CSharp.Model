using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>month.date.integer@row</c>.</summary>
public sealed record MonthDateIntegerRow : IOperator
{
    public MonthDateIntegerRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeInteger();
}
