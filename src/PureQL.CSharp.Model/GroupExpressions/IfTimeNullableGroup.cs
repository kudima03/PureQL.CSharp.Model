using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.time.nullable@group</c>.</summary>
public sealed record IfTimeNullableGroup : IOperator
{
    public IfTimeNullableGroup(
        TimeNullableGroup then,
        TimeNullableGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public TimeNullableGroup Then { get; }

    public TimeNullableGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeTimeNullable();
}
