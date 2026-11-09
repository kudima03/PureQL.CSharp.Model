using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.decimal.nullable@row</c>.</summary>
public sealed record CoalesceDecimalNullableRow : IOperator
{
    public CoalesceDecimalNullableRow(
        IEnumerable<IntegerNullableOrDecimalNullableRow> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableOrDecimalNullableRow> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
