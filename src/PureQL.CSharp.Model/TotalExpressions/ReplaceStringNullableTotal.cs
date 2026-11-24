using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>replace.string.nullable@total</c>.</summary>
public sealed record ReplaceStringNullableTotal : IOperator
{
    public ReplaceStringNullableTotal(
        StringNullableTotal operand,
        StringNullableTotal pattern,
        StringNullableTotal replacement
    )
    {
        Operand = operand;
        Pattern = pattern;
        Replacement = replacement;
    }

    public StringNullableTotal Operand { get; }

    public StringNullableTotal Pattern { get; }

    public StringNullableTotal Replacement { get; }

    public IType Type => new TypeStringNullable();
}
