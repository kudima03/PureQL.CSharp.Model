using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.string.nullable@group</c>.</summary>
public sealed record LeastStringNullableGroup : IOperator
{
    public LeastStringNullableGroup(IEnumerable<StringNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableGroup> Values { get; }

    public IType Type => new TypeStringNullable();
}
