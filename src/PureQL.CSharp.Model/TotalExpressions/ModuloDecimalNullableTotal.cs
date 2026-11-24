using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>modulo.decimal.nullable@total</c>.</summary>
public sealed record ModuloDecimalNullableTotal : IOperator
{
    public ModuloDecimalNullableTotal(
        DecimalNullableTotal left,
        DecimalNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableTotal Left { get; }

    public DecimalNullableTotal Right { get; }

    public IType Type => new TypeDecimalNullable();
}
