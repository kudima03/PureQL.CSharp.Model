using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>modulo.integer.nullable@total</c>.</summary>
public sealed record ModuloIntegerNullableTotal : IOperator
{
    public ModuloIntegerNullableTotal(
        IntegerNullableTotal left,
        IntegerNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableTotal Left { get; }

    public IntegerNullableTotal Right { get; }

    public IType Type => new TypeIntegerNullable();
}
