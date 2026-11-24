using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>nullIfEqual.integer.nullable@row</c>.</summary>
public sealed record NullIfEqualIntegerNullableRow : IOperator
{
    public NullIfEqualIntegerNullableRow(
        IntegerNullableRow left,
        DecimalNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeIntegerNullable();
}
