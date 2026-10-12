using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record LessThanOrEqualStringRow : IOperator
{
    public LessThanOrEqualStringRow(StringNullableRow left, StringNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableRow Left { get; }

    public StringNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
