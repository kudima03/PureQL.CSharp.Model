using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>equal.string@row</c>.</summary>
public sealed record EqualStringRow : IOperator
{
    public EqualStringRow(StringNullableRow left, StringNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableRow Left { get; }

    public StringNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
