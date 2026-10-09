namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DateAddDaysDateProjection
{
    public DateAddDaysDateProjection(DateProjection left, IntegerProjection right)
    {
        Left = left;
        Right = right;
    }

    public DateProjection Left { get; }

    public IntegerProjection Right { get; }
}
