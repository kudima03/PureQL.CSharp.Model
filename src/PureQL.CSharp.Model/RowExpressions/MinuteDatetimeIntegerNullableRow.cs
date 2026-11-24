using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>minute.datetime.integer.nullable@row</c>.</summary>
public sealed record MinuteDatetimeIntegerNullableRow : IOperator
{
    public MinuteDatetimeIntegerNullableRow(
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
