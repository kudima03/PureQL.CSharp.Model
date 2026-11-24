using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.time@group</c>.</summary>
public sealed record LeastTimeGroup : IOperator
{
    public LeastTimeGroup(IEnumerable<TimeGroup> values)
    {
        Values = values;
    }

    public IEnumerable<TimeGroup> Values { get; }

    public IType Type => new TypeTime();
}
