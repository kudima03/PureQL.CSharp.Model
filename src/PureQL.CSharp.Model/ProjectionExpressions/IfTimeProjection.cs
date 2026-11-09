using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.time@projection</c>.</summary>
public sealed record IfTimeProjection : IOperator
{
    public IfTimeProjection(
        TimeProjection then,
        TimeProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public TimeProjection Then { get; }

    public TimeProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeTime();
}
