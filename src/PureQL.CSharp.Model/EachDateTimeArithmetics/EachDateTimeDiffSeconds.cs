using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachDateTimeArithmetics;

public sealed record EachDateTimeDiffSeconds
{
    public EachDateTimeDiffSeconds(
        OneOf<DateTimeReturning, DateTimeArrayReturning> left,
        OneOf<DateTimeReturning, DateTimeArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public OneOf<DateTimeReturning, DateTimeArrayReturning> Left { get; }

    public OneOf<DateTimeReturning, DateTimeArrayReturning> Right { get; }
}
