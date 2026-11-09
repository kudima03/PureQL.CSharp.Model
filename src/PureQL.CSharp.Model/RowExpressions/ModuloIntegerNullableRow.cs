using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>modulo.integer.nullable@row</c>.</summary>
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
