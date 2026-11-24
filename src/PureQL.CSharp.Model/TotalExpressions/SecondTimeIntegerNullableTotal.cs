using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>second.time.integer.nullable@total</c>.</summary>
public sealed record SecondTimeIntegerNullableTotal : IOperator
{
    public SecondTimeIntegerNullableTotal(DeclaresTimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
