using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.datetime.nullable@group</c>.</summary>
public sealed record GreatestDatetimeNullableGroup : IOperator
{
    public GreatestDatetimeNullableGroup(IEnumerable<DatetimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableGroup> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
