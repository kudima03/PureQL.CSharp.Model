using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>nullIfEqual.boolean.nullable@row</c>.</summary>
public sealed record NullIfEqualBooleanNullableRow : IOperator
{
    public NullIfEqualBooleanNullableRow(
        BooleanNullableRow left,
        BooleanNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableRow Left { get; }

    public BooleanNullableRow Right { get; }

    public IType Type => new TypeBooleanNullable();
}
