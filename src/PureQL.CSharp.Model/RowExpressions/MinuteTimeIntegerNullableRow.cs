using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>minute.time.integer.nullable@row</c>.</summary>
public sealed record MinuteTimeIntegerNullableRow : IOperator
{
    public MinuteTimeIntegerNullableRow(DeclaresTimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
