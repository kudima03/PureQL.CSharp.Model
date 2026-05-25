using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachEqualities;

public sealed record EachTimeEquality
{
    public EachTimeEquality(
        TimeArrayReturning left,
        OneOf<TimeReturning, TimeArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeArrayReturning Left { get; }

    public OneOf<TimeReturning, TimeArrayReturning> Right { get; }
}
