using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfStringTotal : IOperator
{
    public IfStringTotal(BooleanTotal condition, StringTotal then, StringTotal @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public StringTotal Then { get; }

    public StringTotal Else { get; }

    public IType Type => new TypeString();
}
