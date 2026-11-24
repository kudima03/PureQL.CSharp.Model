using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asTime.datetime.time@row</c>.</summary>
public sealed record AsTimeDatetimeTimeRow : IOperator
{
    public AsTimeDatetimeTimeRow(DatetimeRow operand, StringRow? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeRow Operand { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeTime();
}
