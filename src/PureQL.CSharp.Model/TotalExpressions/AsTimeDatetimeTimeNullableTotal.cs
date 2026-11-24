using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asTime.datetime.time.nullable@total</c>.</summary>
public sealed record AsTimeDatetimeTimeNullableTotal : IOperator
{
    public AsTimeDatetimeTimeNullableTotal(
        DatetimeNullableTotal operand,
        StringNullableTotal? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableTotal Operand { get; }

    public StringNullableTotal? Zone { get; }

    public IType Type => new TypeTimeNullable();
}
