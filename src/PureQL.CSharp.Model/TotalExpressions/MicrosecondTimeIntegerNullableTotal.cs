using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>microsecond.time.integer.nullable@total</c>.</summary>
public sealed record MicrosecondTimeIntegerNullableTotal : IOperator
{
    public MicrosecondTimeIntegerNullableTotal(DeclaresTimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
