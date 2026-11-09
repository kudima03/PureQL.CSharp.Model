using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.integer@projection</c>.</summary>
public sealed record IfIntegerProjection : IOperator
{
    public IfIntegerProjection(
        IntegerProjection then,
        IntegerProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public IntegerProjection Then { get; }

    public IntegerProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeInteger();
}
