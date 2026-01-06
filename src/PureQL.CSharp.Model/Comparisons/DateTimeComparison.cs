using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Comparisons;

public sealed record DateTimeComparison
{
    public DateTimeComparison(
        ComparisonOperator @operator,
        DateTimeReturning left,
        DateTimeReturning right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public ComparisonOperator Operator { get; }

    public DateTimeReturning Left { get; }

    public DateTimeReturning Right { get; }
}
