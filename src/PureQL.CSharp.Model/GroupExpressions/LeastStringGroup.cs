using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.string@group</c>.</summary>
public sealed record LeastStringGroup : IOperator
{
    public LeastStringGroup(IEnumerable<StringGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringGroup> Values { get; }

    public IType Type => new TypeString();
}
