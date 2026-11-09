using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.time@group</c>.</summary>
public sealed record CoalesceTimeGroup : IOperator
{
    public CoalesceTimeGroup(IEnumerable<TimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableGroup> Values { get; }

    public IType Type => new TypeTime();
}
