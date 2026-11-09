using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.uuid.nullable@total</c>.</summary>
public sealed record CoalesceUuidNullableTotal : IOperator
{
    public CoalesceUuidNullableTotal(IEnumerable<DeclaresUuidNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresUuidNullableTotal> Values { get; }

    public IType Type => new TypeUuidNullable();
}
