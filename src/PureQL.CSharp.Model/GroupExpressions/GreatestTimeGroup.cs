using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.time@group</c>.</summary>
public sealed record GreatestTimeGroup : IOperator
{
    public GreatestTimeGroup(IEnumerable<TimeGroup> values)
    {
        Values = values;
    }

    public IEnumerable<TimeGroup> Values { get; }

    public IType Type => new TypeTime();
}
