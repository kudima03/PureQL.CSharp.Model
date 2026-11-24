using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.boolean.nullable@group</c>.</summary>
public sealed record LeastBooleanNullableGroup : IOperator
{
    public LeastBooleanNullableGroup(IEnumerable<BooleanNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableGroup> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
