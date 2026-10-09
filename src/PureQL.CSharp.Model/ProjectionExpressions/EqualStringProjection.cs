namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record EqualStringProjection
{
    public EqualStringProjection(
        StringNullableProjection left,
        StringNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableProjection Left { get; }

    public StringNullableProjection Right { get; }
}
