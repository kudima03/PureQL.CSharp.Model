using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.datetime@total</c>.</summary>
public sealed record IfDatetimeTotal : IOperator
{
    public IfDatetimeTotal(
        DatetimeTotal then,
        DatetimeTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DatetimeTotal Then { get; }

    public DatetimeTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeDatetime();
}
