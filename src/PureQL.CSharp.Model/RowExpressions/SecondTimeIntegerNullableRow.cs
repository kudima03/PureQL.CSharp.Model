using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>second.time.integer.nullable@row</c>.</summary>
public sealed record SecondTimeIntegerNullableRow : IOperator
{
    public SecondTimeIntegerNullableRow(DeclaresTimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
