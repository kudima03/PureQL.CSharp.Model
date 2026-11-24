using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfQuarter.date.nullable@row</c>.</summary>
public sealed record StartOfQuarterDateNullableRow : IOperator
{
    public StartOfQuarterDateNullableRow(DeclaresDateNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableRow Operand { get; }

    public IType Type => new TypeDateNullable();
}
