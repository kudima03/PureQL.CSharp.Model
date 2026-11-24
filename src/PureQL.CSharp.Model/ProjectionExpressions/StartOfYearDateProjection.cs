using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfYear.date@projection</c>.</summary>
public sealed record StartOfYearDateProjection : IOperator
{
    public StartOfYearDateProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeDate();
}
