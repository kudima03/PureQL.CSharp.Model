using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.datetime@group</c>.</summary>
public sealed record CoalesceDatetimeGroup : IOperator
{
    public CoalesceDatetimeGroup(IEnumerable<DatetimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableGroup> Values { get; }

    public IType Type => new TypeDatetime();
}
