using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>timeAddSeconds.time@projection</c>.</summary>
public sealed record TimeAddSecondsTimeProjection : IOperator
{
    public TimeAddSecondsTimeProjection(TimeProjection left, DecimalProjection right)
    {
        Left = left;
        Right = right;
    }

    public TimeProjection Left { get; }

    public DecimalProjection Right { get; }

    public IType Type => new TypeTime();
}
