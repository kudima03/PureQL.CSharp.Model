using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.boolean.nullable@total</c>.</summary>
public sealed record IfBooleanNullableTotal : IOperator
{
    public IfBooleanNullableTotal(
        BooleanNullableTotal then,
        BooleanNullableTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public BooleanNullableTotal Then { get; }

    public BooleanNullableTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeBooleanNullable();
}
