using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfBooleanTotal : IOperator
{
    public IfBooleanTotal(BooleanTotal condition, BooleanTotal then, BooleanTotal @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public BooleanTotal Then { get; }

    public BooleanTotal Else { get; }

    public IType Type => new TypeBoolean();
}
