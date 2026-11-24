using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfSecond.time.nullable@total</c>.</summary>
public sealed record StartOfSecondTimeNullableTotal : IOperator
{
    public StartOfSecondTimeNullableTotal(DeclaresTimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableTotal Operand { get; }

    public IType Type => new TypeTimeNullable();
}
