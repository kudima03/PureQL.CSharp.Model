using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.integer.nullable@group</c>.</summary>
public sealed record LeastIntegerNullableGroup : IOperator
{
    public LeastIntegerNullableGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
