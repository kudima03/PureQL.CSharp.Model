using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.time.nullable@group</c>.</summary>
public sealed record CoalesceTimeNullableGroup : IOperator
{
    public CoalesceTimeNullableGroup(IEnumerable<DeclaresTimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresTimeNullableGroup> Values { get; }

    public IType Type => new TypeTimeNullable();
}
