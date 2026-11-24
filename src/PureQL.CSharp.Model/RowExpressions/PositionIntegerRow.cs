using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>position.integer@row</c>.</summary>
public sealed record PositionIntegerRow : IOperator
{
    public PositionIntegerRow(
        StringRow operand,
        StringRow pattern,
        IntegerRow? start = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Start = start;
    }

    public StringRow Operand { get; }

    public StringRow Pattern { get; }

    public IntegerRow? Start { get; }

    public IType Type => new TypeInteger();
}
