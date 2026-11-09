using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.date.nullable@group</c>.</summary>
public sealed record IfDateNullableGroup : IOperator
{
    public IfDateNullableGroup(
        DateNullableGroup then,
        DateNullableGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DateNullableGroup Then { get; }

    public DateNullableGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeDateNullable();
}
