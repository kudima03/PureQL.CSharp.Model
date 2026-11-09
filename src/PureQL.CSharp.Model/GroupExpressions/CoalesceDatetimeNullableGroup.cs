using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.datetime.nullable@group</c>.</summary>
public sealed record CoalesceDatetimeNullableGroup : IOperator
{
    public CoalesceDatetimeNullableGroup(
        IEnumerable<DeclaresDatetimeNullableGroup> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresDatetimeNullableGroup> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
