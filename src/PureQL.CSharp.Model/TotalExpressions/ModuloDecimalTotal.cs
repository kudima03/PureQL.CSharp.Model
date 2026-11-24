using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>modulo.decimal@total</c>.</summary>
public sealed record ModuloDecimalTotal : IOperator
{
    public ModuloDecimalTotal(DecimalTotal left, DecimalTotal right)
    {
        Left = left;
        Right = right;
    }

    public DecimalTotal Left { get; }

    public DecimalTotal Right { get; }

    public IType Type => new TypeDecimal();
}
