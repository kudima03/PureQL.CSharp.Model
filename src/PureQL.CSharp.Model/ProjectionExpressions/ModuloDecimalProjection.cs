using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>modulo.decimal@projection</c>.</summary>
public sealed record ModuloDecimalProjection : IOperator
{
    public ModuloDecimalProjection(DecimalProjection left, DecimalProjection right)
    {
        Left = left;
        Right = right;
    }

    public DecimalProjection Left { get; }

    public DecimalProjection Right { get; }

    public IType Type => new TypeDecimal();
}
