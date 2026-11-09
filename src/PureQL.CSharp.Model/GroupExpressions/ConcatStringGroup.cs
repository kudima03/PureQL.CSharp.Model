using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>concat.string@group</c>.</summary>
public sealed record ConcatStringGroup : IOperator
{
    public ConcatStringGroup(IEnumerable<StringGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringGroup> Values { get; }

    public IType Type => new TypeString();
}
