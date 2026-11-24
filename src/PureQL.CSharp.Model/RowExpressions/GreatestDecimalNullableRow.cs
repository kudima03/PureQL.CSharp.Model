using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.decimal.nullable@row</c>.</summary>
public sealed record GreatestDecimalNullableRow : IOperator
{
    public GreatestDecimalNullableRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
