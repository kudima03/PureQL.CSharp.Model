using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>hour.time.integer.nullable@total</c>.</summary>
public sealed record HourTimeIntegerNullableTotal : IOperator
{
    public HourTimeIntegerNullableTotal(DeclaresTimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
