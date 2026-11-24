using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>week.datetime.integer@row</c>.</summary>
public sealed record WeekDatetimeIntegerRow : IOperator
{
    public WeekDatetimeIntegerRow(DatetimeRow operand, StringRow? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeRow Operand { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeInteger();
}
