using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>nullIfEqual.decimal.nullable@row</c>.</summary>
public sealed record NullIfEqualDecimalNullableRow : IOperator
{
    public NullIfEqualDecimalNullableRow(
        DecimalOrDecimalNullableRow left,
        DecimalNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalOrDecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeDecimalNullable();
}
