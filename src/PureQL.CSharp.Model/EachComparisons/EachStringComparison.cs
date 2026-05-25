using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachComparisons;

public sealed record EachStringComparison
{
    public EachStringComparison(
        EachComparisonOperator @operator,
        StringArrayReturning left,
        OneOf<StringReturning, StringArrayReturning> right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public EachComparisonOperator Operator { get; }

    public StringArrayReturning Left { get; }

    public OneOf<StringReturning, StringArrayReturning> Right { get; }
}
