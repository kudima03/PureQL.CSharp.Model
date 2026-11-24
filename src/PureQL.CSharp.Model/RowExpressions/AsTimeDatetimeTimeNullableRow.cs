using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asTime.datetime.time.nullable@row</c>.</summary>
public sealed record AsTimeDatetimeTimeNullableRow : IOperator
{
    public AsTimeDatetimeTimeNullableRow(
        DatetimeNullableRow operand,
        StringNullableRow? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableRow Operand { get; }

    public StringNullableRow? Zone { get; }

    public IType Type => new TypeTimeNullable();
}
