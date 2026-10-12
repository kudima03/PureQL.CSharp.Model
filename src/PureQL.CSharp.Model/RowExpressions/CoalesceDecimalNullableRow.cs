using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDecimalNullableRow : IOperator
{
    public CoalesceDecimalNullableRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
