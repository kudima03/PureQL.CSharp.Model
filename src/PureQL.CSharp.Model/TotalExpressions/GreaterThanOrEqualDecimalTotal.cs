using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.decimal@total</c>.</summary>
public sealed record GreaterThanOrEqualDecimalTotal : IOperator
{
    public GreaterThanOrEqualDecimalTotal(
        DecimalNullableTotal left,
        DecimalNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableTotal Left { get; }

    public DecimalNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
