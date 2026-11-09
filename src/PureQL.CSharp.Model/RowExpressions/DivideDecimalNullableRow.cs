using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>divide.decimal.nullable@row</c>.</summary>
public sealed record DivideDecimalNullableRow : IOperator
{
    public DivideDecimalNullableRow(IEnumerable<DecimalNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableRow> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
