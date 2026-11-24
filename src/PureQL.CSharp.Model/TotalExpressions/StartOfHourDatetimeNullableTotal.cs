using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfHour.datetime.nullable@total</c>.</summary>
public sealed record StartOfHourDatetimeNullableTotal : IOperator
{
    public StartOfHourDatetimeNullableTotal(
        DatetimeNullableTotal operand,
        StringNullableTotal? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableTotal Operand { get; }

    public StringNullableTotal? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
