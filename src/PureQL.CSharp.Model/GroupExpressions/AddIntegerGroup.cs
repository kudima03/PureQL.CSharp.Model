using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>add.integer@group</c>.</summary>
public sealed record AddIntegerGroup : IOperator
{
    public AddIntegerGroup(IEnumerable<IntegerGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerGroup> Values { get; }

    public IType Type => new TypeInteger();
}
