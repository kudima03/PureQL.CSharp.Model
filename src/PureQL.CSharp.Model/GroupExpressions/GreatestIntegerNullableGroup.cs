using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.integer.nullable@group</c>.</summary>
public sealed record GreatestIntegerNullableGroup : IOperator
{
    public GreatestIntegerNullableGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
