using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.datetime.nullable@group</c>.</summary>
public sealed record LeastDatetimeNullableGroup : IOperator
{
    public LeastDatetimeNullableGroup(IEnumerable<DatetimeNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableGroup> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
