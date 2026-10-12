using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanOrEqualBooleanRow : IOperator
{
    public LessThanOrEqualBooleanRow(BooleanNullableRow left, BooleanNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableRow Left { get; }

    public BooleanNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
