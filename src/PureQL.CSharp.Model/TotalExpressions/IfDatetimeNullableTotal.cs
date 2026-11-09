using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.datetime.nullable@total</c>.</summary>
public sealed record IfDatetimeNullableTotal : IOperator
{
    public IfDatetimeNullableTotal(
        DatetimeNullableTotal then,
        DatetimeNullableTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DatetimeNullableTotal Then { get; }

    public DatetimeNullableTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeDatetimeNullable();
}
