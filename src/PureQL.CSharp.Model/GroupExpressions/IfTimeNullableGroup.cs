using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfTimeNullableGroup : IOperator
{
    public IfTimeNullableGroup(
        BooleanGroup condition,
        TimeNullableGroup then,
        TimeNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public TimeNullableGroup Then { get; }

    public TimeNullableGroup Else { get; }

    public IType Type => new TypeTimeNullable();
}
