using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Comparisons;

public sealed record StringComparison
{
    public StringComparison(
        ComparisonOperator @operator,
        StringReturning left,
        StringReturning right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public ComparisonOperator Operator { get; }

    public StringReturning Left { get; }

    public StringReturning Right { get; }
}
