using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateAddDays.date@projection</c>.</summary>
public sealed record DateAddDaysDateProjection : IOperator
{
    public DateAddDaysDateProjection(DateProjection operand, IntegerProjection days)
    {
        Operand = operand;
        Days = days;
    }

    public DateProjection Operand { get; }

    public IntegerProjection Days { get; }

    public IType Type => new TypeDate();
}
