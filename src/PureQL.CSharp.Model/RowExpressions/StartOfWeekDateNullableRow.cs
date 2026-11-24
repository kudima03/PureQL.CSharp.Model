using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfWeek.date.nullable@row</c>.</summary>
public sealed record StartOfWeekDateNullableRow : IOperator
{
    public StartOfWeekDateNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeDateNullable();
}
