using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.uuid.nullable@projection</c>.</summary>
public sealed record IfUuidNullableProjection : IOperator
{
    public IfUuidNullableProjection(
        UuidNullableProjection then,
        UuidNullableProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public UuidNullableProjection Then { get; }

    public UuidNullableProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeUuidNullable();
}
