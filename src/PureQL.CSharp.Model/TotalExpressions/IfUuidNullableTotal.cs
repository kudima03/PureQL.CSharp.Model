using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfUuidNullableTotal : IOperator
{
    public IfUuidNullableTotal(
        BooleanTotal condition,
        UuidNullableTotal then,
        UuidNullableTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public UuidNullableTotal Then { get; }

    public UuidNullableTotal Else { get; }

    public IType Type => new TypeUuidNullable();
}
