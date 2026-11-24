using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>nullIfEqual.integer.nullable@total</c>.</summary>
public sealed record NullIfEqualIntegerNullableTotal : IOperator
{
    public NullIfEqualIntegerNullableTotal(
        IntegerNullableTotal left,
        DecimalNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableTotal Left { get; }

    public DecimalNullableTotal Right { get; }

    public IType Type => new TypeIntegerNullable();
}
