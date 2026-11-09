using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.integer@total</c>.</summary>
public sealed record IfIntegerTotal : IOperator
{
    public IfIntegerTotal(IntegerTotal then, IntegerTotal @else, BooleanTotal condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public IntegerTotal Then { get; }

    public IntegerTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeInteger();
}
