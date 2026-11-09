using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateDiffDays.integer.nullable@row</c>.</summary>
public sealed record DateDiffDaysIntegerNullableRow : IOperator
{
    public DateDiffDaysIntegerNullableRow(DateNullableRow left, DateNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableRow Left { get; }

    public DateNullableRow Right { get; }

    public IType Type => new TypeIntegerNullable();
}
