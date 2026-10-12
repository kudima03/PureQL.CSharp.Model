using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record ModuloIntegerNullableRow : IOperator
{
    public ModuloIntegerNullableRow(IntegerNullableRow left, IntegerNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableRow Left { get; }

    public IntegerNullableRow Right { get; }

    public IType Type => new TypeIntegerNullable();
}
