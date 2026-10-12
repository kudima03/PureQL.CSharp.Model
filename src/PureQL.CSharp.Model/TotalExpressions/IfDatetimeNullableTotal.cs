using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfDatetimeNullableTotal : IOperator
{
    public IfDatetimeNullableTotal(
        BooleanTotal condition,
        DatetimeNullableTotal then,
        DatetimeNullableTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public DatetimeNullableTotal Then { get; }

    public DatetimeNullableTotal Else { get; }

    public IType Type => new TypeDatetimeNullable();
}
