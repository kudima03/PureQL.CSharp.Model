using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceUuidNullableRow : IOperator
{
    public CoalesceUuidNullableRow(IEnumerable<UuidNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableRow> Values { get; }

    public IType Type => new TypeUuidNullable();
}
