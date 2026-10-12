using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record DateDiffDaysIntegerNullableTotal : IOperator
{
    public DateDiffDaysIntegerNullableTotal(
        DateNullableTotal left,
        DateNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableTotal Left { get; }

    public DateNullableTotal Right { get; }

    public IType Type => new TypeIntegerNullable();
}
