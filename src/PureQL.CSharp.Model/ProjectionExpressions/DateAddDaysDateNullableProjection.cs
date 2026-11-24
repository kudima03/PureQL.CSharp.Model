using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateAddDays.date.nullable@projection</c>.</summary>
public sealed record DateAddDaysDateNullableProjection : IOperator
{
    public DateAddDaysDateNullableProjection(
        DateNullableProjection operand,
        IntegerNullableProjection days
    )
    {
        Operand = operand;
        Days = days;
    }

    public DateNullableProjection Operand { get; }

    public IntegerNullableProjection Days { get; }

    public IType Type => new TypeDateNullable();
}
