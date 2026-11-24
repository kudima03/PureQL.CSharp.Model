using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>repeat.string@row</c>.</summary>
public sealed record RepeatStringRow : IOperator
{
    public RepeatStringRow(StringRow operand, IntegerRow count)
    {
        Operand = operand;
        Count = count;
    }

    public StringRow Operand { get; }

    public IntegerRow Count { get; }

    public IType Type => new TypeString();
}
