using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfYear.date@row</c>.</summary>
public sealed record StartOfYearDateRow : IOperator
{
    public StartOfYearDateRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeDate();
}
