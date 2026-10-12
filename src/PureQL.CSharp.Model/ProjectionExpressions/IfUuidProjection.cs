using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfUuidProjection : IOperator
{
    public IfUuidProjection(
        BooleanProjection condition,
        UuidProjection then,
        UuidProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public UuidProjection Then { get; }

    public UuidProjection Else { get; }

    public IType Type => new TypeUuid();
}
