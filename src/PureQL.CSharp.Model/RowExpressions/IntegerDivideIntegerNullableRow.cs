using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IntegerDivideIntegerNullableRow : IOperator
{
    public IntegerDivideIntegerNullableRow(
        IntegerNullableRow left,
        IntegerNullableRow right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableRow Left { get; }

    public IntegerNullableRow Right { get; }

    public IType Type => new TypeIntegerNullable();
}
