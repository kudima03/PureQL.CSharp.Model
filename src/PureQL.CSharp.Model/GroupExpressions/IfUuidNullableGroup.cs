using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfUuidNullableGroup : IOperator
{
    public IfUuidNullableGroup(
        BooleanGroup condition,
        UuidNullableGroup then,
        UuidNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public UuidNullableGroup Then { get; }

    public UuidNullableGroup Else { get; }

    public IType Type => new TypeUuidNullable();
}
