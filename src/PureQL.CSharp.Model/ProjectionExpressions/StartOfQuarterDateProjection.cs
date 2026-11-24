using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfQuarter.date@projection</c>.</summary>
public sealed record StartOfQuarterDateProjection : IOperator
{
    public StartOfQuarterDateProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeDate();
}
