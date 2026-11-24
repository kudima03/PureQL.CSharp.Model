using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>quarter.date.integer@row</c>.</summary>
public sealed record QuarterDateIntegerRow : IOperator
{
    public QuarterDateIntegerRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeInteger();
}
