using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.integer@group</c>.</summary>
public sealed record IfIntegerGroup : IOperator
{
    public IfIntegerGroup(IntegerGroup then, IntegerGroup @else, BooleanGroup condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public IntegerGroup Then { get; }

    public IntegerGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeInteger();
}
