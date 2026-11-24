using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>minute.time.integer@row</c>.</summary>
public sealed record MinuteTimeIntegerRow : IOperator
{
    public MinuteTimeIntegerRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeInteger();
}
