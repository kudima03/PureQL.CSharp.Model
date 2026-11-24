using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>nullIfEqual.datetime.nullable@row</c>.</summary>
public sealed record NullIfEqualDatetimeNullableRow : IOperator
{
    public NullIfEqualDatetimeNullableRow(
        DatetimeNullableRow left,
        DatetimeNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableRow Left { get; }

    public DatetimeNullableRow Right { get; }

    public IType Type => new TypeDatetimeNullable();
}
