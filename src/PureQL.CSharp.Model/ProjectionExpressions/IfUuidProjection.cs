using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.uuid@projection</c>.</summary>
public sealed record IfUuidProjection : IOperator
{
    public IfUuidProjection(
        UuidProjection then,
        UuidProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public UuidProjection Then { get; }

    public UuidProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeUuid();
}
