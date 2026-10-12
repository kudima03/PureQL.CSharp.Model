using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceUuidGroup : IOperator
{
    public CoalesceUuidGroup(IEnumerable<UuidNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableGroup> Values { get; }

    public IType Type => new TypeUuid();
}
