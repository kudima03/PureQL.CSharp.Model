using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfMinute.time.nullable@row</c>.</summary>
public sealed record StartOfMinuteTimeNullableRow : IOperator
{
    public StartOfMinuteTimeNullableRow(DeclaresTimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableRow Operand { get; }

    public IType Type => new TypeTimeNullable();
}
