using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.datetime@group</c>.</summary>
public sealed record LeastDatetimeGroup : IOperator
{
    public LeastDatetimeGroup(IEnumerable<DatetimeGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeGroup> Values { get; }

    public IType Type => new TypeDatetime();
}
