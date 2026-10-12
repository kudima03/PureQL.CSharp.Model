using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfIntegerTotal : IOperator
{
    public IfIntegerTotal(BooleanTotal condition, IntegerTotal then, IntegerTotal @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public IntegerTotal Then { get; }

    public IntegerTotal Else { get; }

    public IType Type => new TypeInteger();
}
