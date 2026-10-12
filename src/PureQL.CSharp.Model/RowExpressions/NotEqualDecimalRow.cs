using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record NotEqualDecimalRow : IOperator
{
    public NotEqualDecimalRow(DecimalNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeBoolean();
}
