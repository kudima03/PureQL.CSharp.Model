using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeDiffSeconds.decimal.nullable@row</c>.</summary>
public sealed record DatetimeDiffSecondsDecimalNullableRow : IOperator
{
    public DatetimeDiffSecondsDecimalNullableRow(
        DatetimeNullableRow left,
        DatetimeNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableRow Left { get; }

    public DatetimeNullableRow Right { get; }

    public IType Type => new TypeDecimalNullable();
}
