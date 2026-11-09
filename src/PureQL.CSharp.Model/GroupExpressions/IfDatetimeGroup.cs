using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.datetime@group</c>.</summary>
public sealed record IfDatetimeGroup : IOperator
{
    public IfDatetimeGroup(
        DatetimeGroup then,
        DatetimeGroup @else,
        BooleanGroup condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DatetimeGroup Then { get; }

    public DatetimeGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeDatetime();
}
