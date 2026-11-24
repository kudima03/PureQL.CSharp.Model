using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dayOfYear.datetime.integer.nullable@row</c>.</summary>
public sealed record DayOfYearDatetimeIntegerNullableRow : IOperator
{
    public DayOfYearDatetimeIntegerNullableRow(
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
