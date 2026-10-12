using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record LessThanOrEqualStringProjection : IOperator
{
    public LessThanOrEqualStringProjection(
        StringNullableProjection left,
        StringNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableProjection Left { get; }

    public StringNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
