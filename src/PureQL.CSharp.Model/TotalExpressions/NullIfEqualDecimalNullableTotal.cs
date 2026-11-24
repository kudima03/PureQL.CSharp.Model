using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>nullIfEqual.decimal.nullable@total</c>.</summary>
public sealed record NullIfEqualDecimalNullableTotal : IOperator
{
    public NullIfEqualDecimalNullableTotal(
        DecimalOrDecimalNullableTotal left,
        DecimalNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalOrDecimalNullableTotal Left { get; }

    public DecimalNullableTotal Right { get; }

    public IType Type => new TypeDecimalNullable();
}
