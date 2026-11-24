using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfSecond.time@projection</c>.</summary>
public sealed record StartOfSecondTimeProjection : IOperator
{
    public StartOfSecondTimeProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeTime();
}
