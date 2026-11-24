using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfQuarter.date@row</c>.</summary>
public sealed record StartOfQuarterDateRow : IOperator
{
    public StartOfQuarterDateRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeDate();
}
