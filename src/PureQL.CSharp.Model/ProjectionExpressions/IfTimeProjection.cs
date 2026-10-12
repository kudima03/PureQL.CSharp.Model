using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfTimeProjection : IOperator
{
    public IfTimeProjection(
        BooleanProjection condition,
        TimeProjection then,
        TimeProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public TimeProjection Then { get; }

    public TimeProjection Else { get; }

    public IType Type => new TypeTime();
}
