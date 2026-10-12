using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfStringGroup : IOperator
{
    public IfStringGroup(BooleanGroup condition, StringGroup then, StringGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public StringGroup Then { get; }

    public StringGroup Else { get; }

    public IType Type => new TypeString();
}
