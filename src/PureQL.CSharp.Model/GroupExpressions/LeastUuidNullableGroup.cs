using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.uuid.nullable@group</c>.</summary>
public sealed record LeastUuidNullableGroup : IOperator
{
    public LeastUuidNullableGroup(IEnumerable<UuidNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableGroup> Values { get; }

    public IType Type => new TypeUuidNullable();
}
