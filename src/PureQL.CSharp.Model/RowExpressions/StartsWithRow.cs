using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startsWith@row</c>.</summary>
public sealed record StartsWithRow : IOperator
{
    public StartsWithRow(StringNullableRow operand, StringNullableRow pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableRow Operand { get; }

    public StringNullableRow Pattern { get; }

    public IType Type => new TypeBoolean();
}
