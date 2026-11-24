using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.datetime@group</c>.</summary>
public sealed record GreatestDatetimeGroup : IOperator
{
    public GreatestDatetimeGroup(IEnumerable<DatetimeGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeGroup> Values { get; }

    public IType Type => new TypeDatetime();
}
