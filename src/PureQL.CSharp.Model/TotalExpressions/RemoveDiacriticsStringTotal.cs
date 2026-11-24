using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>removeDiacritics.string@total</c>.</summary>
public sealed record RemoveDiacriticsStringTotal : IOperator
{
    public RemoveDiacriticsStringTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeString();
}
