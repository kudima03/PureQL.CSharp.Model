using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.time.nullable@total</c>.</summary>
public sealed record IfTimeNullableTotal : IOperator
{
    public IfTimeNullableTotal(
        TimeNullableTotal then,
        TimeNullableTotal @else,
        BooleanTotal condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public TimeNullableTotal Then { get; }

    public TimeNullableTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeTimeNullable();
}
