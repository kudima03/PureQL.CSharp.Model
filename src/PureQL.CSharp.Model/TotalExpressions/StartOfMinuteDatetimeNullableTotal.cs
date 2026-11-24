using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfMinute.datetime.nullable@total</c>.</summary>
public sealed record StartOfMinuteDatetimeNullableTotal : IOperator
{
    public StartOfMinuteDatetimeNullableTotal(
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
