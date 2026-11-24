using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>hour.time.integer@row</c>.</summary>
public sealed record HourTimeIntegerRow : IOperator
{
    public HourTimeIntegerRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeInteger();
}
