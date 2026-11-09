using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.time@total</c>.</summary>
public sealed record IfTimeTotal : IOperator
{
    public IfTimeTotal(TimeTotal then, TimeTotal @else, BooleanTotal condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public TimeTotal Then { get; }

    public TimeTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeTime();
}
