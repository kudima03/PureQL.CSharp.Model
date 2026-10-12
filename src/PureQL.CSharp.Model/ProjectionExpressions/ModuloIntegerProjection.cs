using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record ModuloIntegerProjection : IOperator
{
    public ModuloIntegerProjection(IntegerProjection left, IntegerProjection right)
    {
        Left = left;
        Right = right;
    }

    public IntegerProjection Left { get; }

    public IntegerProjection Right { get; }

    public IType Type => new TypeInteger();
}
