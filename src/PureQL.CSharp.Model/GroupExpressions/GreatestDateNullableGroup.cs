using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.date.nullable@group</c>.</summary>
public sealed record GreatestDateNullableGroup : IOperator
{
    public GreatestDateNullableGroup(IEnumerable<DateNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableGroup> Values { get; }

    public IType Type => new TypeDateNullable();
}
