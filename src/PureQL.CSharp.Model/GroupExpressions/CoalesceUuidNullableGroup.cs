using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.uuid.nullable@group</c>.</summary>
public sealed record CoalesceUuidNullableGroup : IOperator
{
    public CoalesceUuidNullableGroup(IEnumerable<DeclaresUuidNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresUuidNullableGroup> Values { get; }

    public IType Type => new TypeUuidNullable();
}
