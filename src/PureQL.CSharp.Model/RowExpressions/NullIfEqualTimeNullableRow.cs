using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>nullIfEqual.time.nullable@row</c>.</summary>
public sealed record NullIfEqualTimeNullableRow : IOperator
{
    public NullIfEqualTimeNullableRow(TimeNullableRow left, TimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableRow Left { get; }

    public TimeNullableRow Right { get; }

    public IType Type => new TypeTimeNullable();
}
