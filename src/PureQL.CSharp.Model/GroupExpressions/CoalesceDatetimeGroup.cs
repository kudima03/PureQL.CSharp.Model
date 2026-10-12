using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDatetimeGroup : IOperator
{
    public CoalesceDatetimeGroup(IEnumerable<DatetimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableGroup> Values { get; }

    public IType Type => new TypeDatetime();
}
