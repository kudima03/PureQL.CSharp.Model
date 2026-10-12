using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfIntegerProjection : IOperator
{
    public IfIntegerProjection(
        BooleanProjection condition,
        IntegerProjection then,
        IntegerProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public IntegerProjection Then { get; }

    public IntegerProjection Else { get; }

    public IType Type => new TypeInteger();
}
