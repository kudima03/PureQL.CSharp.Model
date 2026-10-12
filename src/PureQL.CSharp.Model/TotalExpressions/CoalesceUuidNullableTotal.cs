using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceUuidNullableTotal : IOperator
{
    public CoalesceUuidNullableTotal(IEnumerable<UuidNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableTotal> Values { get; }

    public IType Type => new TypeUuidNullable();
}
