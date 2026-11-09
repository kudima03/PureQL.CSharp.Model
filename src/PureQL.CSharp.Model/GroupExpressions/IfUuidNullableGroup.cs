using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.uuid.nullable@group</c>.</summary>
public sealed record IfUuidNullableGroup : IOperator
{
    public IfUuidNullableGroup(
        UuidNullableGroup then,
        UuidNullableGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public UuidNullableGroup Then { get; }

    public UuidNullableGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeUuidNullable();
}
