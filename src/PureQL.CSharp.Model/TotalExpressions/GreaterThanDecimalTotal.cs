using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record GreaterThanDecimalTotal : IOperator
{
    public GreaterThanDecimalTotal(DecimalNullableTotal left, DecimalNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableTotal Left { get; }

    public DecimalNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
