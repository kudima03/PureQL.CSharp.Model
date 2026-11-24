using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateDiffMonths.integer.nullable@total</c>.</summary>
public sealed record DateDiffMonthsIntegerNullableTotal : IOperator
{
    public DateDiffMonthsIntegerNullableTotal(
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
