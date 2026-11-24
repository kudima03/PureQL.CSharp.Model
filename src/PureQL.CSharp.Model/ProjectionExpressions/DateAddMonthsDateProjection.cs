using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateAddMonths.date@projection</c>.</summary>
public sealed record DateAddMonthsDateProjection : IOperator
{
    public DateAddMonthsDateProjection(DateProjection operand, IntegerProjection months)
    {
        Operand = operand;
        Months = months;
    }

    public DateProjection Operand { get; }

    public IntegerProjection Months { get; }

    public IType Type => new TypeDate();
}
