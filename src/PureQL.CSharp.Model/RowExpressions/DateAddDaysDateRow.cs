using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateAddDays.date@row</c>.</summary>
public sealed record DateAddDaysDateRow : IOperator
{
    public DateAddDaysDateRow(DateRow operand, IntegerRow days)
    {
        Operand = operand;
        Days = days;
    }

    public DateRow Operand { get; }

    public IntegerRow Days { get; }

    public IType Type => new TypeDate();
}
