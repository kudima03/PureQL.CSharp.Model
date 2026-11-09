using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>equal.time@row</c>.</summary>
public sealed record EqualTimeRow : IOperator
{
    public EqualTimeRow(TimeNullableRow left, TimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableRow Left { get; }

    public TimeNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
