using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Comparisons;

public sealed record TimeComparison
{
    public TimeComparison(
        ComparisonOperator @operator,
        TimeReturning left,
        TimeReturning right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public ComparisonOperator Operator { get; }

    public TimeReturning Left { get; }

    public TimeReturning Right { get; }
}
