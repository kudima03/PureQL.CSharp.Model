namespace PureQL.CSharp.Model.Comparisons;

public sealed record DateTimeComparison
{
    public DateTimeComparison(
        ComparisonOperator @operator,
        DateTimeComparison left,
        DateTimeComparison right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public ComparisonOperator Operator { get; }

    public DateTimeComparison Left { get; }

    public DateTimeComparison Right { get; }
}
