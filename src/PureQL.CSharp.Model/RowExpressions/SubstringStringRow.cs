using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>substring.string@row</c>.</summary>
public sealed record SubstringStringRow : IOperator
{
    public SubstringStringRow(
        StringRow operand,
        IntegerRow start,
        IntegerRow? length = null
    )
    {
        Operand = operand;
        Start = start;
        Length = length;
    }

    public StringRow Operand { get; }

    public IntegerRow Start { get; }

    public IntegerRow? Length { get; }

    public IType Type => new TypeString();
}
