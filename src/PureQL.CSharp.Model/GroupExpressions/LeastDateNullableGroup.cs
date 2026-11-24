using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.date.nullable@group</c>.</summary>
public sealed record LeastDateNullableGroup : IOperator
{
    public LeastDateNullableGroup(IEnumerable<DateNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableGroup> Values { get; }

    public IType Type => new TypeDateNullable();
}
