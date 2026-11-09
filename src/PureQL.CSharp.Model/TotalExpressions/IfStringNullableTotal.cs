using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.string.nullable@total</c>.</summary>
public sealed record IfStringNullableTotal : IOperator
{
    public IfStringNullableTotal(
        StringNullableTotal then,
        StringNullableTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public StringNullableTotal Then { get; }

    public StringNullableTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeStringNullable();
}
