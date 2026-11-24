using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfHour.time.nullable@total</c>.</summary>
public sealed record StartOfHourTimeNullableTotal : IOperator
{
    public StartOfHourTimeNullableTotal(DeclaresTimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableTotal Operand { get; }

    public IType Type => new TypeTimeNullable();
}
