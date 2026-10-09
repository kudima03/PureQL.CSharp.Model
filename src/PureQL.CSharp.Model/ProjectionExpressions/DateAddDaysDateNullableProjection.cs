namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DateAddDaysDateNullableProjection
{
    public DateAddDaysDateNullableProjection(
        DateNullableProjection left,
        IntegerNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableProjection Left { get; }

    public IntegerNullableProjection Right { get; }
}
