using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.boolean@group</c>.</summary>
public sealed record GreatestBooleanGroup : IOperator
{
    public GreatestBooleanGroup(IEnumerable<BooleanGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanGroup> Values { get; }

    public IType Type => new TypeBoolean();
}
