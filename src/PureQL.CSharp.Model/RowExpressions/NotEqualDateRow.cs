using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record NotEqualDateRow : IOperator
{
    public NotEqualDateRow(DateNullableRow left, DateNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableRow Left { get; }

    public DateNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
