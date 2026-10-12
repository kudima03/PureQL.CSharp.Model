using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDateNullableGroup : IOperator
{
    public IfDateNullableGroup(
        BooleanGroup condition,
        DateNullableGroup then,
        DateNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DateNullableGroup Then { get; }

    public DateNullableGroup Else { get; }

    public IType Type => new TypeDateNullable();
}
