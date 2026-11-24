using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.time.nullable@group</c>.</summary>
public sealed record LeastTimeNullableGroup : IOperator
{
    public LeastTimeNullableGroup(IEnumerable<TimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableGroup> Values { get; }

    public IType Type => new TypeTimeNullable();
}
