using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDatetimeGroup : IOperator
{
    public IfDatetimeGroup(
        BooleanGroup condition,
        DatetimeGroup then,
        DatetimeGroup @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DatetimeGroup Then { get; }

    public DatetimeGroup Else { get; }

    public IType Type => new TypeDatetime();
}
