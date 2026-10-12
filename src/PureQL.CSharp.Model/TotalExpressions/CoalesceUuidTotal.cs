using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceUuidTotal : IOperator
{
    public CoalesceUuidTotal(IEnumerable<UuidNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableTotal> Values { get; }

    public IType Type => new TypeUuid();
}
