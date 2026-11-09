using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.date@total</c>.</summary>
public sealed record IfDateTotal : IOperator
{
    public IfDateTotal(DateTotal then, DateTotal @else, BooleanTotal condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DateTotal Then { get; }

    public DateTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeDate();
}
