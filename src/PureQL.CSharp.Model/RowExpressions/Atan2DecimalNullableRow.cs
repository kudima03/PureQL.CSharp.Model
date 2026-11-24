using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>atan2.decimal.nullable@row</c>.</summary>
public sealed record Atan2DecimalNullableRow : IOperator
{
    public Atan2DecimalNullableRow(DecimalNullableRow y, DecimalNullableRow x)
    {
        Y = y;
        X = x;
    }

    public DecimalNullableRow Y { get; }

    public DecimalNullableRow X { get; }

    public IType Type => new TypeDecimalNullable();
}
