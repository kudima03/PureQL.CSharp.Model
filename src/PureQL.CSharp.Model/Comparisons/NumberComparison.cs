using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Comparisons;

public sealed record NumberComparison
{
    public NumberComparison(
        ComparisonOperator @operator,
        NumberReturning left,
        NumberReturning right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public ComparisonOperator Operator { get; }

    public NumberReturning Left { get; }

    public NumberReturning Right { get; }
}
