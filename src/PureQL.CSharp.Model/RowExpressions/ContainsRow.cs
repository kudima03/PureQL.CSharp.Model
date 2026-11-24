using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>contains@row</c>.</summary>
public sealed record ContainsRow : IOperator
{
    public ContainsRow(StringNullableRow operand, StringNullableRow pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableRow Operand { get; }

    public StringNullableRow Pattern { get; }

    public IType Type => new TypeBoolean();
}
