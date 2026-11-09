using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.uuid.nullable@row</c>.</summary>
public sealed record CoalesceUuidNullableRow : IOperator
{
    public CoalesceUuidNullableRow(IEnumerable<DeclaresUuidNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresUuidNullableRow> Values { get; }

    public IType Type => new TypeUuidNullable();
}
