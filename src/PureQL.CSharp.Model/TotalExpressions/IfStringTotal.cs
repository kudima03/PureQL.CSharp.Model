using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.string@total</c>.</summary>
public sealed record IfStringTotal : IOperator
{
    public IfStringTotal(StringTotal then, StringTotal @else, BooleanTotal condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public StringTotal Then { get; }

    public StringTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeString();
}
