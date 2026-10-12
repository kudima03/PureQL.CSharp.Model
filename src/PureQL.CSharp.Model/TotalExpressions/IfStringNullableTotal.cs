using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfStringNullableTotal : IOperator
{
    public IfStringNullableTotal(
        BooleanTotal condition,
        StringNullableTotal then,
        StringNullableTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public StringNullableTotal Then { get; }

    public StringNullableTotal Else { get; }

    public IType Type => new TypeStringNullable();
}
