using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfBooleanNullableTotal : IOperator
{
    public IfBooleanNullableTotal(
        BooleanTotal condition,
        BooleanNullableTotal then,
        BooleanNullableTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public BooleanNullableTotal Then { get; }

    public BooleanNullableTotal Else { get; }

    public IType Type => new TypeBooleanNullable();
}
