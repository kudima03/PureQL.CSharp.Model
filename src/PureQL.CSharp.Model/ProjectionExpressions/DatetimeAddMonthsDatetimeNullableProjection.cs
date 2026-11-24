using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>datetimeAddMonths.datetime.nullable@projection</c>.</summary>
public sealed record DatetimeAddMonthsDatetimeNullableProjection : IOperator
{
    public DatetimeAddMonthsDatetimeNullableProjection(
        DatetimeNullableProjection operand,
        IntegerNullableProjection months,
        StringNullableProjection? zone = null
    )
    {
        Operand = operand;
        Months = months;
        Zone = zone;
    }

    public DatetimeNullableProjection Operand { get; }

    public IntegerNullableProjection Months { get; }

    public StringNullableProjection? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
