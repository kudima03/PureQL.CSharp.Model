using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateDiffMonths.integer.nullable@row</c>.</summary>
public sealed record DateDiffMonthsIntegerNullableRow : IOperator
{
    public DateDiffMonthsIntegerNullableRow(DateNullableRow left, DateNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableRow Left { get; }

    public DateNullableRow Right { get; }

    public IType Type => new TypeIntegerNullable();
}
