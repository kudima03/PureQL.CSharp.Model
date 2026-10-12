using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDatetimeNullableGroup : IOperator
{
    public CoalesceDatetimeNullableGroup(IEnumerable<DatetimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableGroup> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
