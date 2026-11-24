using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>second.time.integer@row</c>.</summary>
public sealed record SecondTimeIntegerRow : IOperator
{
    public SecondTimeIntegerRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeInteger();
}
