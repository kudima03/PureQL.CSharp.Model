using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>nullIfEqual.date.nullable@row</c>.</summary>
public sealed record NullIfEqualDateNullableRow : IOperator
{
    public NullIfEqualDateNullableRow(DateNullableRow left, DateNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableRow Left { get; }

    public DateNullableRow Right { get; }

    public IType Type => new TypeDateNullable();
}
