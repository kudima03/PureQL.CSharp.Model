using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.date.nullable@group</c>.</summary>
public sealed record CoalesceDateNullableGroup : IOperator
{
    public CoalesceDateNullableGroup(IEnumerable<DeclaresDateNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresDateNullableGroup> Values { get; }

    public IType Type => new TypeDateNullable();
}
