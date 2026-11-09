using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.string@group</c>.</summary>
public sealed record IfStringGroup : IOperator
{
    public IfStringGroup(StringGroup then, StringGroup @else, BooleanGroup condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public StringGroup Then { get; }

    public StringGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeString();
}
