using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.uuid@group</c>.</summary>
public sealed record GreatestUuidGroup : IOperator
{
    public GreatestUuidGroup(IEnumerable<UuidGroup> values)
    {
        Values = values;
    }

    public IEnumerable<UuidGroup> Values { get; }

    public IType Type => new TypeUuid();
}
