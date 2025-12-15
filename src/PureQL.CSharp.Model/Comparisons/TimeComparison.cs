namespace PureQL.CSharp.Model.Comparisons;

public sealed record TimeComparison
{
    public TimeComparison(
        ComparisonOperator @operator,
        TimeComparison left,
        TimeComparison right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public ComparisonOperator Operator { get; }

    public TimeComparison Left { get; }

    public TimeComparison Right { get; }
}
