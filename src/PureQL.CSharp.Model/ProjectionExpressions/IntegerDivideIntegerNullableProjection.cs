using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IntegerDivideIntegerNullableProjection : IOperator
{
    public IntegerDivideIntegerNullableProjection(
        IntegerNullableProjection left,
        IntegerNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableProjection Left { get; }

    public IntegerNullableProjection Right { get; }

    public IType Type => new TypeIntegerNullable();
}
