using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDateGroup : IOperator
{
    public IfDateGroup(BooleanGroup condition, DateGroup then, DateGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DateGroup Then { get; }

    public DateGroup Else { get; }

    public IType Type => new TypeDate();
}
