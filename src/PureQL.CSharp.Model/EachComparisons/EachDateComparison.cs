using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachComparisons;

public sealed record EachDateComparison
{
    public EachDateComparison(
        EachComparisonOperator @operator,
        DateArrayReturning left,
        OneOf<DateReturning, DateArrayReturning> right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public EachComparisonOperator Operator { get; }

    public DateArrayReturning Left { get; }

    public OneOf<DateReturning, DateArrayReturning> Right { get; }
}
