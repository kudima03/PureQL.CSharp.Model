using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record GreaterThanStringRow : IOperator
{
    public GreaterThanStringRow(StringNullableRow left, StringNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableRow Left { get; }

    public StringNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
