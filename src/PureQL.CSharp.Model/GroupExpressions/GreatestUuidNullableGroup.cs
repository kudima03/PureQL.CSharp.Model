using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.uuid.nullable@group</c>.</summary>
public sealed record GreatestUuidNullableGroup : IOperator
{
    public GreatestUuidNullableGroup(IEnumerable<UuidNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableGroup> Values { get; }

    public IType Type => new TypeUuidNullable();
}
