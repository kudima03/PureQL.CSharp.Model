using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.uuid.nullable@row</c>.</summary>
public sealed record LeastUuidNullableRow : IOperator
{
    public LeastUuidNullableRow(IEnumerable<UuidNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableRow> Values { get; }

    public IType Type => new TypeUuidNullable();
}
