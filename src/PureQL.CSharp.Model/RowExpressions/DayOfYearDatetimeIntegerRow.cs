using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dayOfYear.datetime.integer@row</c>.</summary>
public sealed record DayOfYearDatetimeIntegerRow : IOperator
{
    public DayOfYearDatetimeIntegerRow(DatetimeRow operand, StringRow? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeRow Operand { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeInteger();
}
