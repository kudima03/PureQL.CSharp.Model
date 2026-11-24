using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfMonth.datetime.nullable@row</c>.</summary>
public sealed record StartOfMonthDatetimeNullableRow : IOperator
{
    public StartOfMonthDatetimeNullableRow(
        DatetimeNullableRow operand,
        StringNullableRow? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableRow Operand { get; }

    public StringNullableRow? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
