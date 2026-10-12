using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfDatetimeTotal : IOperator
{
    public IfDatetimeTotal(
        BooleanTotal condition,
        DatetimeTotal then,
        DatetimeTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public DatetimeTotal Then { get; }

    public DatetimeTotal Else { get; }

    public IType Type => new TypeDatetime();
}
