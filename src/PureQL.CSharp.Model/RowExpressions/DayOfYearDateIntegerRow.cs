using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dayOfYear.date.integer@row</c>.</summary>
public sealed record DayOfYearDateIntegerRow : IOperator
{
    public DayOfYearDateIntegerRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeInteger();
}
