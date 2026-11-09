using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.date.nullable@total</c>.</summary>
public sealed record IfDateNullableTotal : IOperator
{
    public IfDateNullableTotal(
        DateNullableTotal then,
        DateNullableTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DateNullableTotal Then { get; }

    public DateNullableTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeDateNullable();
}
