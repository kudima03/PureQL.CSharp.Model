using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>replace.string@total</c>.</summary>
public sealed record ReplaceStringTotal : IOperator
{
    public ReplaceStringTotal(
        StringTotal operand,
        StringTotal pattern,
        StringTotal replacement
    )
    {
        Operand = operand;
        Pattern = pattern;
        Replacement = replacement;
    }

    public StringTotal Operand { get; }

    public StringTotal Pattern { get; }

    public StringTotal Replacement { get; }

    public IType Type => new TypeString();
}
