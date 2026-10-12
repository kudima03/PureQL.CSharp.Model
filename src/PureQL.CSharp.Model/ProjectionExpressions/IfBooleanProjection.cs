using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfBooleanProjection : IOperator
{
    public IfBooleanProjection(
        BooleanProjection condition,
        BooleanProjection then,
        BooleanProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public BooleanProjection Then { get; }

    public BooleanProjection Else { get; }

    public IType Type => new TypeBoolean();
}
