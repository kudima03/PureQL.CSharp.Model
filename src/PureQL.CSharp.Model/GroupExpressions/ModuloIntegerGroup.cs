using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>modulo.integer@group</c>.</summary>
public sealed record ModuloIntegerGroup : IOperator
{
    public ModuloIntegerGroup(IntegerGroup left, IntegerGroup right)
    {
        Left = left;
        Right = right;
    }

    public IntegerGroup Left { get; }

    public IntegerGroup Right { get; }

    public IType Type => new TypeInteger();
}
