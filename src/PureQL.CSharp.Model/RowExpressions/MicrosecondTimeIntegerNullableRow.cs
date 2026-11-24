using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>microsecond.time.integer.nullable@row</c>.</summary>
public sealed record MicrosecondTimeIntegerNullableRow : IOperator
{
    public MicrosecondTimeIntegerNullableRow(DeclaresTimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
