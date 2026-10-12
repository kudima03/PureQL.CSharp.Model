using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfDecimalNullableTotal : IOperator
{
    public IfDecimalNullableTotal(
        BooleanTotal condition,
        DecimalNullableTotal then,
        DecimalNullableTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public DecimalNullableTotal Then { get; }

    public DecimalNullableTotal Else { get; }

    public IType Type => new TypeDecimalNullable();
}
