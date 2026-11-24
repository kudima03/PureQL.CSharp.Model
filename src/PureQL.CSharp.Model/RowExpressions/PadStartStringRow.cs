using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>padStart.string@row</c>.</summary>
public sealed record PadStartStringRow : IOperator
{
    public PadStartStringRow(StringRow operand, IntegerRow length, StringRow fill)
    {
        Operand = operand;
        Length = length;
        Fill = fill;
    }

    public StringRow Operand { get; }

    public IntegerRow Length { get; }

    public StringRow Fill { get; }

    public IType Type => new TypeString();
}
