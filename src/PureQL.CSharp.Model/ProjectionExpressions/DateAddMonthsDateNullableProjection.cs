using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateAddMonths.date.nullable@projection</c>.</summary>
public sealed record DateAddMonthsDateNullableProjection : IOperator
{
    public DateAddMonthsDateNullableProjection(
        DateNullableProjection operand,
        IntegerNullableProjection months
    )
    {
        Operand = operand;
        Months = months;
    }

    public DateNullableProjection Operand { get; }

    public IntegerNullableProjection Months { get; }

    public IType Type => new TypeDateNullable();
}
