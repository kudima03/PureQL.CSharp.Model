using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>replace.string@row</c>.</summary>
public sealed record ReplaceStringRow : IOperator
{
    public ReplaceStringRow(StringRow operand, StringRow pattern, StringRow replacement)
    {
        Operand = operand;
        Pattern = pattern;
        Replacement = replacement;
    }

    public StringRow Operand { get; }

    public StringRow Pattern { get; }

    public StringRow Replacement { get; }

    public IType Type => new TypeString();
}
