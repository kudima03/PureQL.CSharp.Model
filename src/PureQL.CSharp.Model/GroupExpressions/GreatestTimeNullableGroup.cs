using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.time.nullable@group</c>.</summary>
public sealed record GreatestTimeNullableGroup : IOperator
{
    public GreatestTimeNullableGroup(IEnumerable<TimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableGroup> Values { get; }

    public IType Type => new TypeTimeNullable();
}
