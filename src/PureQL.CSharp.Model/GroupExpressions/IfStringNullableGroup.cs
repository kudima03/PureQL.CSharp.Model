using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.string.nullable@group</c>.</summary>
public sealed record IfStringNullableGroup : IOperator
{
    public IfStringNullableGroup(
        StringNullableGroup then,
        StringNullableGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public StringNullableGroup Then { get; }

    public StringNullableGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeStringNullable();
}
