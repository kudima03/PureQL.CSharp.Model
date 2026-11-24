using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>replace.string.nullable@row</c>.</summary>
public sealed record ReplaceStringNullableRow : IOperator
{
    public ReplaceStringNullableRow(
        StringNullableRow operand,
        StringNullableRow pattern,
        StringNullableRow replacement
    )
    {
        Operand = operand;
        Pattern = pattern;
        Replacement = replacement;
    }

    public StringNullableRow Operand { get; }

    public StringNullableRow Pattern { get; }

    public StringNullableRow Replacement { get; }

    public IType Type => new TypeStringNullable();
}
