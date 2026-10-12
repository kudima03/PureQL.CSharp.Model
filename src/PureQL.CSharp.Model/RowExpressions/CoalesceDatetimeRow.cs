using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDatetimeRow : IOperator
{
    public CoalesceDatetimeRow(IEnumerable<DatetimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableRow> Values { get; }

    public IType Type => new TypeDatetime();
}
