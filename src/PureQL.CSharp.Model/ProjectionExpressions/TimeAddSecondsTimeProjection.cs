using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>timeAddSeconds.time@projection</c>.</summary>
public sealed record TimeAddSecondsTimeProjection : IOperator
{
    public TimeAddSecondsTimeProjection(TimeProjection operand, DecimalProjection seconds)
    {
        Operand = operand;
        Seconds = seconds;
    }

    public TimeProjection Operand { get; }

    public DecimalProjection Seconds { get; }

    public IType Type => new TypeTime();
}
