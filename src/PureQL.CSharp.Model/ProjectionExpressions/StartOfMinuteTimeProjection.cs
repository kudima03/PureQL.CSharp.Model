using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfMinute.time@projection</c>.</summary>
public sealed record StartOfMinuteTimeProjection : IOperator
{
    public StartOfMinuteTimeProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeTime();
}
