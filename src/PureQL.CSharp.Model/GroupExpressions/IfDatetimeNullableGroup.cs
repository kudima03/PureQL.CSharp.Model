using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDatetimeNullableGroup : IOperator
{
    public IfDatetimeNullableGroup(
        BooleanGroup condition,
        DatetimeNullableGroup then,
        DatetimeNullableGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DatetimeNullableGroup Then { get; }

    public DatetimeNullableGroup Else { get; }

    public IType Type => new TypeDatetimeNullable();
}
