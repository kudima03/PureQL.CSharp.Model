using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.decimal.nullable@total</c>.</summary>
public sealed record IfDecimalNullableTotal : IOperator
{
    public IfDecimalNullableTotal(
        DecimalNullableTotal then,
        DecimalNullableTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DecimalNullableTotal Then { get; }

    public DecimalNullableTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeDecimalNullable();
}
