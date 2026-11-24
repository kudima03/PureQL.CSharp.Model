using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>endsWith@row</c>.</summary>
public sealed record EndsWithRow : IOperator
{
    public EndsWithRow(StringNullableRow operand, StringNullableRow pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableRow Operand { get; }

    public StringNullableRow Pattern { get; }

    public IType Type => new TypeBoolean();
}
