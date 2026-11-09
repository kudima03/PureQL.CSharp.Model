using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>integerDivide.integer.nullable@total</c>.</summary>
public sealed record IntegerDivideIntegerNullableTotal : IOperator
{
    public IntegerDivideIntegerNullableTotal(
        IntegerNullableTotal left,
        IntegerNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableTotal Left { get; }

    public IntegerNullableTotal Right { get; }

    public IType Type => new TypeIntegerNullable();
}
