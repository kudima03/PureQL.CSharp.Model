using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.datetime.nullable@group</c>.</summary>
public sealed record IfDatetimeNullableGroup : IOperator
{
    public IfDatetimeNullableGroup(
        DatetimeNullableGroup then,
        DatetimeNullableGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DatetimeNullableGroup Then { get; }

    public DatetimeNullableGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeDatetimeNullable();
}
