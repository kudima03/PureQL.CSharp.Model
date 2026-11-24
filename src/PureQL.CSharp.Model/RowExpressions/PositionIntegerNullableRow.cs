using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>position.integer.nullable@row</c>.</summary>
public sealed record PositionIntegerNullableRow : IOperator
{
    public PositionIntegerNullableRow(
        StringNullableRow operand,
        StringNullableRow pattern,
        IntegerNullableRow? start = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Start = start;
    }

    public StringNullableRow Operand { get; }

    public StringNullableRow Pattern { get; }

    public IntegerNullableRow? Start { get; }

    public IType Type => new TypeIntegerNullable();
}
