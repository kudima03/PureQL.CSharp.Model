using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>integerDivide.integer@projection</c>.</summary>
public sealed record IntegerDivideIntegerProjection : IOperator
{
    public IntegerDivideIntegerProjection(DecimalProjection left, DecimalProjection right)
    {
        Left = left;
        Right = right;
    }

    public DecimalProjection Left { get; }

    public DecimalProjection Right { get; }

    public IType Type => new TypeInteger();
}
