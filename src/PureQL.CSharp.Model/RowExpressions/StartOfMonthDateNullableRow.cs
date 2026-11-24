using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfMonth.date.nullable@row</c>.</summary>
public sealed record StartOfMonthDateNullableRow : IOperator
{
    public StartOfMonthDateNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeDateNullable();
}
