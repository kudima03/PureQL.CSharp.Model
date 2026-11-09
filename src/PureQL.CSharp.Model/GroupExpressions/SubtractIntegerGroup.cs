using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>subtract.integer@group</c>.</summary>
public sealed record SubtractIntegerGroup : IOperator
{
    public SubtractIntegerGroup(IEnumerable<IntegerGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerGroup> Values { get; }

    public IType Type => new TypeInteger();
}
