using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.boolean.nullable@group</c>.</summary>
public sealed record IfBooleanNullableGroup : IOperator
{
    public IfBooleanNullableGroup(
        BooleanNullableGroup then,
        BooleanNullableGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public BooleanNullableGroup Then { get; }

    public BooleanNullableGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeBooleanNullable();
}
