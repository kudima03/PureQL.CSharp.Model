using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachComparisons;

public sealed record EachDateTimeComparison
{
    public EachDateTimeComparison(
        EachComparisonOperator @operator,
        DateTimeArrayReturning left,
        OneOf<DateTimeReturning, DateTimeArrayReturning> right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public EachComparisonOperator Operator { get; }

    public DateTimeArrayReturning Left { get; }

    public OneOf<DateTimeReturning, DateTimeArrayReturning> Right { get; }
}
