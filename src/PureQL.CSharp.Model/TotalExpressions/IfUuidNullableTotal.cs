using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.uuid.nullable@total</c>.</summary>
public sealed record IfUuidNullableTotal : IOperator
{
    public IfUuidNullableTotal(
        UuidNullableTotal then,
        UuidNullableTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public UuidNullableTotal Then { get; }

    public UuidNullableTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeUuidNullable();
}
