using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>weekYear.datetime.integer.nullable@total</c>.</summary>
public sealed record WeekYearDatetimeIntegerNullableTotal : IOperator
{
    public WeekYearDatetimeIntegerNullableTotal(
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
