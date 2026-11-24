using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>modulo.decimal@row</c>.</summary>
public sealed record ModuloDecimalRow : IOperator
{
    public ModuloDecimalRow(DecimalRow left, DecimalRow right)
    {
        Left = left;
        Right = right;
    }

    public DecimalRow Left { get; }

    public DecimalRow Right { get; }

    public IType Type => new TypeDecimal();
}
