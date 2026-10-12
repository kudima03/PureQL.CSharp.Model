using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

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
