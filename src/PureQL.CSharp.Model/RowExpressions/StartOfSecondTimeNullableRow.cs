using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfSecond.time.nullable@row</c>.</summary>
public sealed record StartOfSecondTimeNullableRow : IOperator
{
    public StartOfSecondTimeNullableRow(DeclaresTimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableRow Operand { get; }

    public IType Type => new TypeTimeNullable();
}
