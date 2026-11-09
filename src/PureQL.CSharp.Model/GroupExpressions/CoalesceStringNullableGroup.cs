using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.string.nullable@group</c>.</summary>
public sealed record CoalesceStringNullableGroup : IOperator
{
    public CoalesceStringNullableGroup(IEnumerable<DeclaresStringNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresStringNullableGroup> Values { get; }

    public IType Type => new TypeStringNullable();
}
