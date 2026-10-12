using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDatetimeNullableRow : IOperator
{
    public CoalesceDatetimeNullableRow(IEnumerable<DatetimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableRow> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
