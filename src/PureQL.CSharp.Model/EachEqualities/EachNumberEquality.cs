using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachEqualities;

public sealed record EachNumberEquality
{
    public EachNumberEquality(
        NumberArrayReturning left,
        OneOf<NumberReturning, NumberArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public NumberArrayReturning Left { get; }

    public OneOf<NumberReturning, NumberArrayReturning> Right { get; }
}
