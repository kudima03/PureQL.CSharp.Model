using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record EqualDecimalProjection : IOperator
{
    public EqualDecimalProjection(
        DecimalNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
