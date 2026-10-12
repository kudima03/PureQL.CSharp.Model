using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDateGroup : IOperator
{
    public CoalesceDateGroup(IEnumerable<DateNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableGroup> Values { get; }

    public IType Type => new TypeDate();
}
