using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greaterThan.boolean@row</c>.</summary>
public sealed record GreaterThanBooleanRow : IOperator
{
    public GreaterThanBooleanRow(BooleanNullableRow left, BooleanNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableRow Left { get; }

    public BooleanNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
