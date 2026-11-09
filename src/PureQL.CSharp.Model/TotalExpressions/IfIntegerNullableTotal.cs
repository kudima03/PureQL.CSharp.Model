using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.integer.nullable@total</c>.</summary>
public sealed record IfIntegerNullableTotal : IOperator
{
    public IfIntegerNullableTotal(
        IntegerNullableTotal then,
        IntegerNullableTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public IntegerNullableTotal Then { get; }

    public IntegerNullableTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeIntegerNullable();
}
