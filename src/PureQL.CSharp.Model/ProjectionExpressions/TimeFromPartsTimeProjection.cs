using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>timeFromParts.time@projection</c>.</summary>
public sealed record TimeFromPartsTimeProjection : IOperator
{
    public TimeFromPartsTimeProjection(
        IntegerProjection hour,
        IntegerProjection minute,
        DecimalProjection second
    )
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public IntegerProjection Hour { get; }

    public IntegerProjection Minute { get; }

    public DecimalProjection Second { get; }

    public IType Type => new TypeTime();
}
