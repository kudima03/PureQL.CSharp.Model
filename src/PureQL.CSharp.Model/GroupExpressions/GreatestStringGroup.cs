using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.string@group</c>.</summary>
public sealed record GreatestStringGroup : IOperator
{
    public GreatestStringGroup(IEnumerable<StringGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringGroup> Values { get; }

    public IType Type => new TypeString();
}
