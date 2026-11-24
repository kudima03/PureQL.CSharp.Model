using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>month.datetime.integer.nullable@total</c>.</summary>
public sealed record MonthDatetimeIntegerNullableTotal : IOperator
{
    public MonthDatetimeIntegerNullableTotal(
        DatetimeNullableTotal operand,
        StringNullableTotal? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableTotal Operand { get; }

    public StringNullableTotal? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
