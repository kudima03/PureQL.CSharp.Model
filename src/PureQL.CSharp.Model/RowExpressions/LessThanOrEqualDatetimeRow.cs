using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>lessThanOrEqual.datetime@row</c>.</summary>
public sealed record LessThanOrEqualDatetimeRow : IOperator
{
    public LessThanOrEqualDatetimeRow(DatetimeNullableRow left, DatetimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableRow Left { get; }

    public DatetimeNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
