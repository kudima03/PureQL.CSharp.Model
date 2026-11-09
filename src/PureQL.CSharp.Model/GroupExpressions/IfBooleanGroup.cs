using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.boolean@group</c>.</summary>
public sealed record IfBooleanGroup : IOperator
{
    public IfBooleanGroup(BooleanGroup then, BooleanGroup @else, BooleanGroup condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public BooleanGroup Then { get; }

    public BooleanGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeBoolean();
}
