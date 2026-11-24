using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>padEnd.string@row</c>.</summary>
public sealed record PadEndStringRow : IOperator
{
    public PadEndStringRow(StringRow operand, IntegerRow length, StringRow fill)
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
