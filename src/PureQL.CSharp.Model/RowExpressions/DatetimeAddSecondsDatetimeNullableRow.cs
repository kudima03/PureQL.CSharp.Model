using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime.nullable@row</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeNullableRow : IOperator
{
    public DatetimeAddSecondsDatetimeNullableRow(
        DatetimeNullableRow left,
        DecimalNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeDatetimeNullable();
}
