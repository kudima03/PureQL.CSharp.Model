using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>hour.time.integer.nullable@row</c>.</summary>
public sealed record HourTimeIntegerNullableRow : IOperator
{
    public HourTimeIntegerNullableRow(DeclaresTimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
