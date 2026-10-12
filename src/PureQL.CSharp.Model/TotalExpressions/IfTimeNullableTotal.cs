using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfTimeNullableTotal : IOperator
{
    public IfTimeNullableTotal(
        BooleanTotal condition,
        TimeNullableTotal then,
        TimeNullableTotal @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public TimeNullableTotal Then { get; }

    public TimeNullableTotal Else { get; }

    public IType Type => new TypeTimeNullable();
}
