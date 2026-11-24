using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dayOfWeek.datetime.integer.nullable@row</c>.</summary>
public sealed record DayOfWeekDatetimeIntegerNullableRow : IOperator
{
    public DayOfWeekDatetimeIntegerNullableRow(
        DatetimeNullableRow operand,
        StringNullableRow? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableRow Operand { get; }

    public StringNullableRow? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
