using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.uuid@group</c>.</summary>
public sealed record LeastUuidGroup : IOperator
{
    public LeastUuidGroup(IEnumerable<UuidGroup> values)
    {
        Values = values;
    }

    public IEnumerable<UuidGroup> Values { get; }

    public IType Type => new TypeUuid();
}
