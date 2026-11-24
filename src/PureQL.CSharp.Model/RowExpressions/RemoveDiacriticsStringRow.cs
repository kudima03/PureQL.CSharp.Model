using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>removeDiacritics.string@row</c>.</summary>
public sealed record RemoveDiacriticsStringRow : IOperator
{
    public RemoveDiacriticsStringRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeString();
}
