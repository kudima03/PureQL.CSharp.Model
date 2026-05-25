using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachComparisons;

public sealed record EachNumberComparison
{
    public EachNumberComparison(
        EachComparisonOperator @operator,
        NumberArrayReturning left,
        OneOf<NumberReturning, NumberArrayReturning> right
    )
    {
        Operator = @operator;
        Left = left;
        Right = right;
    }

    public EachComparisonOperator Operator { get; }

    public NumberArrayReturning Left { get; }

    public OneOf<NumberReturning, NumberArrayReturning> Right { get; }
}
