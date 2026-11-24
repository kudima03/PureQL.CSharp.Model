using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.uuid.nullable@row</c>.</summary>
public sealed record GreatestUuidNullableRow : IOperator
{
    public GreatestUuidNullableRow(IEnumerable<UuidNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableRow> Values { get; }

    public IType Type => new TypeUuidNullable();
}
