using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfDateNullableTotal : IOperator
{
    public IfDateNullableTotal(
        BooleanTotal condition,
        DateNullableTotal then,
        DateNullableTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public DateNullableTotal Then { get; }

    public DateNullableTotal Else { get; }

    public IType Type => new TypeDateNullable();
}
