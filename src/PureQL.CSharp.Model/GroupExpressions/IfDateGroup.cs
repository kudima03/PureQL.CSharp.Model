using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.date@group</c>.</summary>
public sealed record IfDateGroup : IOperator
{
    public IfDateGroup(DateGroup then, DateGroup @else, BooleanGroup condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DateGroup Then { get; }

    public DateGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeDate();
}
