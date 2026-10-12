using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfDateProjection : IOperator
{
    public IfDateProjection(
        BooleanProjection condition,
        DateProjection then,
        DateProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public DateProjection Then { get; }

    public DateProjection Else { get; }

    public IType Type => new TypeDate();
}
