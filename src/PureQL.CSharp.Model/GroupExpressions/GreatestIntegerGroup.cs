using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.integer@group</c>.</summary>
public sealed record GreatestIntegerGroup : IOperator
{
    public GreatestIntegerGroup(IEnumerable<IntegerGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerGroup> Values { get; }

    public IType Type => new TypeInteger();
}
