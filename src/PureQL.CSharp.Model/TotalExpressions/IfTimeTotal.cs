using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfTimeTotal : IOperator
{
    public IfTimeTotal(BooleanTotal condition, TimeTotal then, TimeTotal @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public TimeTotal Then { get; }

    public TimeTotal Else { get; }

    public IType Type => new TypeTime();
}
