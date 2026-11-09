using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>modulo.integer@total</c>.</summary>
public sealed record ModuloIntegerTotal : IOperator
{
    public ModuloIntegerTotal(IntegerTotal left, IntegerTotal right)
    {
        Left = left;
        Right = right;
    }

    public IntegerTotal Left { get; }

    public IntegerTotal Right { get; }

    public IType Type => new TypeInteger();
}
