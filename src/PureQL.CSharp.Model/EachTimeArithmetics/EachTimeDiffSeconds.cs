using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachTimeArithmetics;

public sealed record EachTimeDiffSeconds
{
    public EachTimeDiffSeconds(
        OneOf<TimeReturning, TimeArrayReturning> left,
        OneOf<TimeReturning, TimeArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public OneOf<TimeReturning, TimeArrayReturning> Left { get; }

    public OneOf<TimeReturning, TimeArrayReturning> Right { get; }
}
