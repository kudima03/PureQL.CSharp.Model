using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>nullIfEqual.string.nullable@row</c>.</summary>
public sealed record NullIfEqualStringNullableRow : IOperator
{
    public NullIfEqualStringNullableRow(StringNullableRow left, StringNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableRow Left { get; }

    public StringNullableRow Right { get; }

    public IType Type => new TypeStringNullable();
}
