using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.time@group</c>.</summary>
public sealed record IfTimeGroup : IOperator
{
    public IfTimeGroup(TimeGroup then, TimeGroup @else, BooleanGroup condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public TimeGroup Then { get; }

    public TimeGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeTime();
}
