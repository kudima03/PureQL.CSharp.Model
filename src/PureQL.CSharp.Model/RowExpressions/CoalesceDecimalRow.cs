using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceDecimalRow : IOperator
{
    public CoalesceDecimalRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }

    public IType Type => new TypeDecimal();
}
