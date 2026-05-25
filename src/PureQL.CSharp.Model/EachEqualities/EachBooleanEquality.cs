using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachEqualities;

public sealed record EachBooleanEquality
{
    public EachBooleanEquality(
        BooleanArrayReturning left,
        OneOf<BooleanReturning, BooleanArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanArrayReturning Left { get; }

    public OneOf<BooleanReturning, BooleanArrayReturning> Right { get; }
}
