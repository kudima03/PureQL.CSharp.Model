using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.boolean@group</c>.</summary>
public sealed record LeastBooleanGroup : IOperator
{
    public LeastBooleanGroup(IEnumerable<BooleanGroup> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanGroup> Values { get; }

    public IType Type => new TypeBoolean();
}
