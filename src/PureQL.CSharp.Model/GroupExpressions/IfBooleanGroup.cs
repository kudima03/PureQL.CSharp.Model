using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfBooleanGroup : IOperator
{
    public IfBooleanGroup(BooleanGroup condition, BooleanGroup then, BooleanGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public BooleanGroup Then { get; }

    public BooleanGroup Else { get; }

    public IType Type => new TypeBoolean();
}
