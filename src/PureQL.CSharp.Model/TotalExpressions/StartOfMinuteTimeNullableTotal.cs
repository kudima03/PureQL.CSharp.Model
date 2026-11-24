using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfMinute.time.nullable@total</c>.</summary>
public sealed record StartOfMinuteTimeNullableTotal : IOperator
{
    public StartOfMinuteTimeNullableTotal(DeclaresTimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableTotal Operand { get; }

    public IType Type => new TypeTimeNullable();
}
