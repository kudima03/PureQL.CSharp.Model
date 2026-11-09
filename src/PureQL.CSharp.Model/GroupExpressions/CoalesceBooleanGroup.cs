using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.boolean@group</c>.</summary>
public sealed record CoalesceBooleanGroup : IOperator
{
    public CoalesceBooleanGroup(IEnumerable<BooleanNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableGroup> Values { get; }

    public IType Type => new TypeBoolean();
}
