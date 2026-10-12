using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDateNullableGroup : IOperator
{
    public CoalesceDateNullableGroup(IEnumerable<DateNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableGroup> Values { get; }

    public IType Type => new TypeDateNullable();
}
