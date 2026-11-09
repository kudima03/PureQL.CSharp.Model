using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.string@group</c>.</summary>
public sealed record CoalesceStringGroup : IOperator
{
    public CoalesceStringGroup(IEnumerable<StringNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableGroup> Values { get; }

    public IType Type => new TypeString();
}
