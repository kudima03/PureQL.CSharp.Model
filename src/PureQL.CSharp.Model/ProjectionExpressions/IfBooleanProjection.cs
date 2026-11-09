using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.boolean@projection</c>.</summary>
public sealed record IfBooleanProjection : IOperator
{
    public IfBooleanProjection(
        BooleanProjection then,
        BooleanProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public BooleanProjection Then { get; }

    public BooleanProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeBoolean();
}
