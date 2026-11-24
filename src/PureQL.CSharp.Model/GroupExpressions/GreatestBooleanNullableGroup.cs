using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.boolean.nullable@group</c>.</summary>
public sealed record GreatestBooleanNullableGroup : IOperator
{
    public GreatestBooleanNullableGroup(IEnumerable<BooleanNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableGroup> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
