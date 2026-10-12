using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfTimeGroup : IOperator
{
    public IfTimeGroup(BooleanGroup condition, TimeGroup then, TimeGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public TimeGroup Then { get; }

    public TimeGroup Else { get; }

    public IType Type => new TypeTime();
}
