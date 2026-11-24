using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>weekYear.date.integer@row</c>.</summary>
public sealed record WeekYearDateIntegerRow : IOperator
{
    public WeekYearDateIntegerRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeInteger();
}
