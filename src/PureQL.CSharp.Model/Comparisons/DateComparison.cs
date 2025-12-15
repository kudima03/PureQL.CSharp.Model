using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Comparisons;

public sealed record DateComparison
{
    public DateComparison(
        ComparisonOperator @operator,
        DateReturning left,
        DateReturning right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public ComparisonOperator Operator { get; }

    public DateReturning Left { get; }

    public DateReturning Right { get; }
}
