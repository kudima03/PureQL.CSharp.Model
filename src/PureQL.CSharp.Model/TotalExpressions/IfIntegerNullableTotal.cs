using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfIntegerNullableTotal : IOperator
{
    public IfIntegerNullableTotal(
        BooleanTotal condition,
        IntegerNullableTotal then,
        IntegerNullableTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public IntegerNullableTotal Then { get; }

    public IntegerNullableTotal Else { get; }

    public IType Type => new TypeIntegerNullable();
}
