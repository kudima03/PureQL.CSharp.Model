using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfDateTotal : IOperator
{
    public IfDateTotal(BooleanTotal condition, DateTotal then, DateTotal @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public DateTotal Then { get; }

    public DateTotal Else { get; }

    public IType Type => new TypeDate();
}
