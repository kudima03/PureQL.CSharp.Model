using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>modulo.decimal.nullable@row</c>.</summary>
public sealed record ModuloDecimalNullableRow : IOperator
{
    public ModuloDecimalNullableRow(DecimalNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeDecimalNullable();
}
