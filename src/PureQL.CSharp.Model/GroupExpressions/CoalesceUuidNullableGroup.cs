using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceUuidNullableGroup : IOperator
{
    public CoalesceUuidNullableGroup(IEnumerable<UuidNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableGroup> Values { get; }

    public IType Type => new TypeUuidNullable();
}
