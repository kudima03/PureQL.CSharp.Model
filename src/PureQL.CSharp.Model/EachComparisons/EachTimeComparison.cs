using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachComparisons;

public sealed record EachTimeComparison
{
    public EachTimeComparison(
        EachComparisonOperator @operator,
        TimeArrayReturning left,
        OneOf<TimeReturning, TimeArrayReturning> right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public EachComparisonOperator Operator { get; }

    public TimeArrayReturning Left { get; }

    public OneOf<TimeReturning, TimeArrayReturning> Right { get; }
}
