using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>minute.time.integer.nullable@total</c>.</summary>
public sealed record MinuteTimeIntegerNullableTotal : IOperator
{
    public MinuteTimeIntegerNullableTotal(DeclaresTimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
