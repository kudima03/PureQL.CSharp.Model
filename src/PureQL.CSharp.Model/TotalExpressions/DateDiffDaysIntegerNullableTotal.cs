using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateDiffDays.integer.nullable@total</c>.</summary>
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
