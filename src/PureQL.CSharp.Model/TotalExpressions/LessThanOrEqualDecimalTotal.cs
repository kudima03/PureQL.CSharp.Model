using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>lessThanOrEqual.decimal@total</c>.</summary>
public sealed record LessThanOrEqualDecimalTotal : IOperator
{
    public LessThanOrEqualDecimalTotal(
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
