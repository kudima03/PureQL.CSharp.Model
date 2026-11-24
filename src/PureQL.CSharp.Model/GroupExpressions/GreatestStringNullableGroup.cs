using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.string.nullable@group</c>.</summary>
public sealed record GreatestStringNullableGroup : IOperator
{
    public GreatestStringNullableGroup(IEnumerable<StringNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableGroup> Values { get; }

    public IType Type => new TypeStringNullable();
}
