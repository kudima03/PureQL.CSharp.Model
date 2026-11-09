using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.date@projection</c>.</summary>
public sealed record IfDateProjection : IOperator
{
    public IfDateProjection(
        DateProjection then,
        DateProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DateProjection Then { get; }

    public DateProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeDate();
}
